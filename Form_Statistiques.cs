using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace TPFinal
{
    public partial class Form_Statistiques : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        private DataSet statsDataSet = new DataSet();
        public Form callBackForm = null;
        private bool currval { get; set; }
        private string commandeSQL { get; set; }
        private string numeroJoueur {get; set;}
        public Form_Statistiques(OracleConnection connect, MaConnection maBelleConnection, string numeroJoueurEnCours)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
            numeroJoueur = numeroJoueurEnCours;
        }

        public string numeroJoueurs
        {
            get
            {
                return TB_NumJoueur.Text;
            }
            set
            {
                TB_NumJoueur.Text = value;
            }
        }

        private void Form_Statistiques_Load(object sender, EventArgs e)
        {
            RemplirFormulaire();
        }
        private void RemplirFormulaire()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            //oraSelect.CommandText = "Select * From Statistiques where NumeroJoueur = :NumeroJoueur";
            oraSelect.CommandText = "Select * From Statistiques " +
                                    "order by NumeroJoueur"; // Problème ici avec le binding context
            oraSelect.Parameters.Add(new OracleParameter(":NumeroJoueur", numeroJoueur));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect))
            {
                if (statsDataSet.Tables.Contains("Stats"))
                {
                    statsDataSet.Tables["Stats"].Clear();
                }
                oraAdapter.Fill(statsDataSet, "Stats");
                oraAdapter.Dispose();
            }
            UpdateLinkTB();
        }
        private void UpdateLinkTB()
        {
            UnbindTB();
            TB_NumJoueur.DataBindings.Add("Text", statsDataSet, "Stats.NumeroJoueur");
            TB_NumMatch.DataBindings.Add("Text", statsDataSet, "Stats.NumeroMatch");
            TB_Nom.DataBindings.Add("Text", statsDataSet, "Stats.NomJoueur");
            TB_Prenom.DataBindings.Add("Text", statsDataSet, "Stats.PrenomJoueur");
            TB_Equipe.DataBindings.Add("Text", statsDataSet, "Stats.NomEquipe");
            TB_NbButs.DataBindings.Add("Text", statsDataSet, "Stats.NombreButs");
            TB_NbPasses.DataBindings.Add("Text", statsDataSet, "Stats.NombrePasses");
            TB_NbPoints.DataBindings.Add("Text", statsDataSet, "Stats.NombrePoints");
            TB_TempsPunition.DataBindings.Add("Text", statsDataSet, "Stats.TempsPunition");
        }
        private void UnbindTB()
        {
            TB_NumJoueur.DataBindings.Clear();
            TB_NumJoueur.Clear();
            TB_NumMatch.DataBindings.Clear();
            TB_NumMatch.Clear();
            TB_Nom.DataBindings.Clear();
            TB_Nom.Clear();
            TB_Prenom.DataBindings.Clear();
            TB_Prenom.Clear();
            TB_Equipe.DataBindings.Clear();
            TB_Equipe.Clear();
            TB_NbButs.DataBindings.Clear();
            TB_NbButs.Clear();
            TB_NbPasses.DataBindings.Clear();
            TB_NbPasses.Clear();
            TB_NbPoints.DataBindings.Clear();
            TB_NbPoints.Clear();
            TB_TempsPunition.DataBindings.Clear();
            TB_TempsPunition.Clear();
        }

        private void Form_Statistiques_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            this.BindingContext[statsDataSet, "Stats"].Position = 0;
        }

        private void BTN_Fin_Click(object sender, EventArgs e)
        {
            this.BindingContext[statsDataSet, "Stats"].Position = this.BindingContext[statsDataSet, "Stats"].Count - 1;
        }

        private void BTN_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[statsDataSet, "Stats"].Position--;
        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[statsDataSet, "Stats"].Position++;
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Stats aJ = new Form_Ajouter_Stats(oracon, connection);
            aJ.callBackForm = this;
            aJ.Text = "Ajout de stats";
            aJ.Location = this.Location;
            this.Hide(); // Cache la fenêtre actuelle

            if (aJ.ShowDialog() == DialogResult.OK)
            {
                string sql = "insert into FicheJoueur" +
                             "(NumeroMatch, NumeroJoueur, NombreButs, NombrePasses, TempsPunition) " +
                             "Values(:NumeroMatch, :NumeroJoueur, :NombreButs, :NombrePasses, :TempsPunition)";
                currval = true;
                try
                {
                    OracleCommand oraAjout = new OracleCommand(sql, oracon);

                    OracleParameter OraParaNumeroMatch = new OracleParameter(":NumeroMatch", OracleDbType.Int32);
                    OracleParameter OraParamNumeroJoueur = new OracleParameter(":NumeroJoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamNombreButs = new OracleParameter(":NombreButs", OracleDbType.Int32);
                    OracleParameter OraParaNombrePasses = new OracleParameter(":NombrePasses", OracleDbType.Int32);
                    OracleParameter OraParaTempsPunition = new OracleParameter(":TempsPunition", OracleDbType.Int32);

                    OraParaNumeroMatch.Value = aJ.numMatch;
                    OraParamNumeroJoueur.Value = aJ.numJoueur;
                    OraParamNombreButs.Value = aJ.nbButs;
                    OraParaNombrePasses.Value = aJ.nbPasses;
                    OraParaTempsPunition.Value = aJ.tempsPunition;

                    oraAjout.Parameters.Add(OraParaNumeroMatch);
                    oraAjout.Parameters.Add(OraParamNumeroJoueur);
                    oraAjout.Parameters.Add(OraParamNombreButs);
                    oraAjout.Parameters.Add(OraParaNombrePasses);
                    oraAjout.Parameters.Add(OraParaTempsPunition);

                    // Ajouter les buts au total
                    string sqlButs = "insert into Match" +
                                     "(NumeroMatch, NumeroJoueur, NombreButs, NombrePasses, TempsPunition)" +
                                     "Values(:NumeroMatch, :NumeroJoueur, :NombreButs, :NombrePasses, :TempsPunition)";
                    OracleCommand oraTotalButs = new OracleCommand(sqlButs, oracon);
                    oraTotalButs.Parameters.Add(OraParamNombreButs);

                    oraAjout.ExecuteNonQuery();
                    RemplirFormulaire();
                }
                catch (OracleException ex) // Erreur "child exists"
                {
                    if (ex.Number == 2292)
                        MessageBox.Show("Le joueur ne doit pas avoir de statistique dans les matchs", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    /* if(ex.Number == 00984)
                         MessageBox.Show("Erreur dans la syntaxe de la commande SQL", "Erreur 00984", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    */
                    else
                        MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Stats ajs = new Form_Ajouter_Stats(oracon, connection);
            ajs.callBackForm = this;
            ajs.Text = "Modification des Statistiques";
            ajs.numMatch = TB_NumMatch.Text;
            ajs.numJoueur = TB_NumJoueur.Text;
            ajs.nbButs = TB_NbButs.Text;
            ajs.nbPasses = TB_NbPasses.Text;
            ajs.tempsPunition = TB_TempsPunition.Text;
            ajs.Location = this.Location;
            ajs.BTN_Ajouter.Text = "Modifier";
            this.Hide();

            if (ajs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "update FicheJoueur set NumeroMatch=:NumeroMatch, NumeroJoueur=:NumeroJoueur, NombreButs=:NombreButs, NombrePasses=:NombrePasses, TempsPunition=:TempsPunition " +
             "where numerojoueur=:numerojoueurs";
                try
                {

                    OracleCommand oraAjout = new OracleCommand(sql, oracon);

                    OracleParameter OraParaNumeroMatch = new OracleParameter(":NumeroMatch", OracleDbType.Int32);
                    OracleParameter OraParamNumeroJoueur = new OracleParameter(":NumeroJoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamNombreButs = new OracleParameter(":NombreButs", OracleDbType.Int32);
                    OracleParameter OraParaNombrePasses = new OracleParameter(":NombrePasses", OracleDbType.Int32);
                    OracleParameter OraParaTempsPunition = new OracleParameter(":TempsPunition", OracleDbType.Int32);

                    OraParaNumeroMatch.Value = ajs.numMatch;
                    OraParamNumeroJoueur.Value = ajs.numJoueur;
                    OraParamNombreButs.Value = ajs.nbButs;
                    OraParaNombrePasses.Value = ajs.nbPasses;
                    OraParaTempsPunition.Value = ajs.tempsPunition;

                    oraAjout.Parameters.Add(OraParaNumeroMatch);
                    oraAjout.Parameters.Add(OraParamNumeroJoueur);
                    oraAjout.Parameters.Add(OraParamNombreButs);
                    oraAjout.Parameters.Add(OraParaNombrePasses);
                    oraAjout.Parameters.Add(OraParaTempsPunition);

                    oraAjout.ExecuteNonQuery();

                    RemplirFormulaire();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment effacer cette entrée ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    OracleParameter paramNomEquipe = new OracleParameter(":numjoueur", OracleDbType.Int32);
                    paramNomEquipe.Value = TB_NumJoueur.Text;
                    string sql = "Delete from joueur Where numerojoueur =:numjoueur";
                    OracleCommand oraDelete = new OracleCommand(sql, oracon);
                    oraDelete.Parameters.Add(paramNomEquipe);
                    oraDelete.ExecuteNonQuery();
                    RemplirFormulaire();
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 2292) // Erreur "child exists"
                        MessageBox.Show("Vous ne pouvez pas effacer des joueurs avec des matchs", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void FB_Fermer_MouseEnter(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = true;
        }

        private void PB_Fermer_Gif_MouseDown(object sender, MouseEventArgs e)
        {
            PB_Fermer_Gif.Visible = false;
            FB_Fermer.BackgroundImage = Properties.Resources.ICON_Fermer_Click;
        }

        private void PB_Fermer_Gif_MouseLeave(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = false;
        }

        private void PB_Fermer_Gif_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
