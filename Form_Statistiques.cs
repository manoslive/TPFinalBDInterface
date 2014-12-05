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
        private DataSet statsDataSet = null;
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
            LoadEquipes();
            //if (numeroJoueurs != null)
            //{
                //try
                //{
                //    OracleCommand oraStats = oracon.CreateCommand();
                //    oraStats.CommandText = " Select * From FicheJoueur where NumeroJoueur = " + numeroJoueurs;
                //    OracleDataAdapter oraAdapter = new OracleDataAdapter(oraStats);
                //    statsDataSet = new DataSet();
                //    oraAdapter.Fill(statsDataSet);
                //    DGV_Stats.DataSource = statsDataSet.Tables[0];

                //    TB_NumJoueur.Text = DGV_Stats.Rows[0].Cells[0].Value.ToString();
                //    TB_Nom.Text = DGV_Stats.Rows[0].Cells[1].Value.ToString();
                //    TB_Prenom.Text = DGV_Stats.Rows[0].Cells[2].Value.ToString();
                //    TB_Equipe.Text = DGV_Stats.Rows[0].Cells[3].Value.ToString();
                //    TB_NbButs.Text = DGV_Stats.Rows[0].Cells[4].Value.ToString();
                //    TB_NbPasses.Text = DGV_Stats.Rows[0].Cells[5].Value.ToString();
                //    TB_NbPoints.Text = DGV_Stats.Rows[0].Cells[6].Value.ToString();
                //    TB_TempsPunition.Text = DGV_Stats.Rows[0].Cells[7].Value.ToString();
                //}
                //catch (OracleException ex)
                //{
                //    MessageBox.Show(ex.Message.ToString());
                //}
            //}
        }
        private void RemplirFormulaire()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "Select * From Statistiques where NumeroJoueur = :NumeroJoueur";
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
            //if (TB_Url.Text != "")
            //    PB_Joueur.ImageLocation = TB_Url.Text;

            UpdateLinkTB();
        }
        private void UpdateLinkTB()
        {
            UnbindTB();
            TB_NumJoueur.DataBindings.Add("Text", statsDataSet, "Stats.NumeroJoueur");
            TB_Nom.DataBindings.Add("Text", statsDataSet, "Stats.NomJoueur");
            TB_Prenom.DataBindings.Add("Text", statsDataSet, "Stats.PrenomJoueur");
            CB_Equipes.DataBindings.Add("SelectedItem", statsDataSet, "Stats.NomEquipe");
            TB_NbButs.DataBindings.Add("Text", statsDataSet, "Stats.NbButs");
            TB_NbPasses.DataBindings.Add("Text", statsDataSet, "Stats.NbPasses");
            TB_NbPoints.DataBindings.Add("Text", statsDataSet, "Stats.NbPoints");
            TB_TempsPunition.DataBindings.Add("Text", statsDataSet, "Stats.TempsPunition");
        }
        private void UnbindTB()
        {
            TB_NumJoueur.DataBindings.Clear();
            TB_NumJoueur.Clear();
            TB_Nom.DataBindings.Clear();
            TB_Nom.Clear();
            TB_Prenom.DataBindings.Clear();
            TB_Prenom.Clear();
            CB_Equipes.DataBindings.Clear();
            CB_Equipes.ResetText();
            TB_NbButs.DataBindings.Clear();
            TB_NbButs.Clear();
            TB_NbPasses.DataBindings.Clear();
            TB_NbPasses.Clear();
            TB_NbPoints.DataBindings.Clear();
            TB_NbPoints.Clear();
            TB_TempsPunition.DataBindings.Clear();
            TB_TempsPunition.Clear();
        }
        private void updateControls()
        {
            if (TB_NumJoueur.Text == "")
            {
                BTN_Modifier.Enabled = false;
                BTN_Debut.Enabled = false;
                BTN_Fin.Enabled = false;
                BTN_Precedent.Enabled = false;
                BTN_Suivant.Enabled = false;
                BTN_Effacer.Enabled = false;
            }
            else
            {
                BTN_Modifier.Enabled = true;
                BTN_Debut.Enabled = true;
                BTN_Fin.Enabled = true;
                BTN_Precedent.Enabled = true;
                BTN_Suivant.Enabled = true;
                BTN_Effacer.Enabled = true;
            }
        }
        private void LoadEquipes()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomEquipe FROM Statistiques";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_Equipes.Items.Add(oraReader.GetString(0));
                }
            }
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
            Form_Ajouter_Joueur aJ = new Form_Ajouter_Joueur(oracon, connection);
            aJ.callBackForm = this;
            aJ.Text = "Ajout de joueur";
            aJ.Location = this.Location;
            this.Hide(); // Cache la fenêtre actuelle

            if (!currval)
                commandeSQL = "SELECT MAX(numjoueur) from joueur ";
            else
                commandeSQL = "SELECT Seq_num_joueur.currval from dual";

            if (aJ.ShowDialog() == DialogResult.OK)
            {
                string sql = "insert into joueur" +
                             "(nomjoueur, prenomjoueur, datenaissance, numeromaillot, photo, positionjoueur, nomequipe)" +
                             "Values(:Nomjoueurs,:Prenomjoueurs,:datenaissance,:numeromaillot,:Photo,:positionjoueur,:equipejoueur)"; //:equipejoueur
                currval = true;
                try
                {
                    OracleCommand oraAjout = new OracleCommand(sql, oracon);

                    OracleParameter OraParaNomjoueurs = new OracleParameter(":Nomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamPrenomjoueurs = new OracleParameter(":Prenomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamdatenaissance = new OracleParameter(":datenaissance", OracleDbType.Date);
                    OracleParameter OraParanumeromaillot = new OracleParameter(":numeromaillot", OracleDbType.Int32);
                    OracleParameter OraParaequipejoueurs = new OracleParameter(":equipejoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParpositionjoueur = new OracleParameter(":positionjoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaPhoto = new OracleParameter(":Photo", OracleDbType.Varchar2, 1500);

                    OraParaNomjoueurs.Value = aJ.nomJoueurs;
                    OraParamPrenomjoueurs.Value = aJ.prenomJoueurs;
                    OraParamdatenaissance.Value = aJ.DDN;// 
                    OraParanumeromaillot.Value = aJ.maillot;
                    OraParaequipejoueurs.Value = aJ.Equipe;
                    OraParpositionjoueur.Value = aJ.Position;
                    OraParaPhoto.Value = aJ.Photo;

                    oraAjout.Parameters.Add(OraParaNomjoueurs);
                    oraAjout.Parameters.Add(OraParamPrenomjoueurs);
                    oraAjout.Parameters.Add(OraParamdatenaissance);
                    oraAjout.Parameters.Add(OraParanumeromaillot);
                    oraAjout.Parameters.Add(OraParaPhoto);
                    oraAjout.Parameters.Add(OraParaequipejoueurs);
                    oraAjout.Parameters.Add(OraParpositionjoueur);


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
            //Form_Ajouter_Stats AjoutStats = new Form_Ajouter_Stats(oracon, connection);
            //this.Hide();
            //AjoutStats.callBackForm = this;
            //AjoutStats.numMatch = DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString();
            //AjoutStats.equipeHome = DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString();
            //AjoutStats.equipeVisiteur = DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString();

            //if (AjoutStats.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string sqlAjoutStats = "insert into FicheJoueur(NumeroMatch,NumeroJoueur,NombreButs,NombrePasses,TempsPunition)" +
            //        " VALUES(:NumeroMatch,:NumeroJoueurs,:NBBUTS,:NBPASSES,:TEMPSPUNITION)";
            //    try
            //    {
            //        OracleCommand oraAjoutStats = new OracleCommand(sqlAjoutStats, oracon);

            //        OracleParameter OraParaNumJoueurs = new OracleParameter(":NumeroJoueurs", OracleDbType.Int32);
            //        OracleParameter OraParaNumMatch = new OracleParameter(":NumeroMatch", OracleDbType.Int32);
            //        OracleParameter OraParaNBButs = new OracleParameter(":NBBUTS", OracleDbType.Int32);
            //        OracleParameter OraParaNbPasses = new OracleParameter(":NBPASSES", OracleDbType.Int32);
            //        OracleParameter OraParaTempsPunition = new OracleParameter(":TEMPSPUNITION", OracleDbType.Int32);

            //        OraParaNumJoueurs.Value = AjoutStats.numJoueurs;
            //        OraParaNumMatch.Value = AjoutStats.numMatch;
            //        OraParaNBButs.Value = AjoutStats.nbButs;
            //        OraParaNbPasses.Value = AjoutStats.nbPasses;
            //        OraParaTempsPunition.Value = AjoutStats.tempsPunition;

            //        oraAjoutStats.Parameters.Add(OraParaNumJoueurs);
            //        oraAjoutStats.Parameters.Add(OraParaNumMatch);
            //        oraAjoutStats.Parameters.Add(OraParaNBButs);
            //        oraAjoutStats.Parameters.Add(OraParaNbPasses);
            //        oraAjoutStats.Parameters.Add(OraParaTempsPunition);


            //        oraAjoutStats.ExecuteNonQuery();
            //    }
            //    catch (OracleException ex)
            //    {
            //        if (ex.Number == 1)
            //        {
            //            MessageBox.Show("Vous ne pouvez pas rajouter des stats de joueurs qui ont deja eu des stats pour le match en visionnement", "Erreur 00001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            MessageBox.Show(ex.Message.ToString());
            //        }
            //    }
            //}
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Stats ajs = new Form_Ajouter_Stats(oracon, connection);
            ajs.callBackForm = this;
            ajs.Text = "Modification du joueur";
            ajs.numMatch = TB_NumMatch.Text;
            ajs.numJoueur = TB_Prenom.Text;
            ajs.nbButs = TB_NbButs.Text;
            ajs.nbPasses = TB_NbPasses.Text;
            ajs.tempsPunition = TB_TempsPunition.Text;
            ajs.Location = this.Location;
            ajs.BTN_Ajouter.Text = "Modifier";
            this.Hide();

            if (ajs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "update FicheJoueur set NumeroMatch=:NumeroMatch, NumeroJoueur=:NumeroJoueur, NombreButs=:NombreButs, NombrePasses=:NombrePasses, TempsPunition=:TempsPunition)" +
             "where numerojoueur=:numerojoueurs)";
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
