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
            oraSelect.CommandText = "Select * From FicheJoueur where NumeroJoueur = :NomEquipe";
            oraSelect.Parameters.Add(new OracleParameter(":NumeroJoueur", numeroJoueur));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect))
            {
                if (statsDataSet.Tables.Contains("Joueur"))
                {
                    statsDataSet.Tables["Joueur"].Clear();
                }
                oraAdapter.Fill(statsDataSet, "Joueur");
                oraAdapter.Dispose();
            }
            //if (TB_Url.Text != "")
            //    PB_Joueur.ImageLocation = TB_Url.Text;

            UpdateLinkTB();
        }
        private void UpdateLinkTB()
        {
            UnbindTB();
            TB_Url.DataBindings.Add("Text", dataSetJoueur, "Joueur.Photo");
            TB_NumJoueur.DataBindings.Add("Text", dataSetJoueur, "Joueur.NumeroJoueur");
            TB_NomJoueur.DataBindings.Add("Text", dataSetJoueur, "Joueur.NomJoueur");
            TB_PrenomJoueur.DataBindings.Add("Text", dataSetJoueur, "Joueur.PrenomJoueur");
            DTP_DateNaissance.DataBindings.Add("Text", dataSetJoueur, "Joueur.DateNaissance");
            TB_NumMaillot.DataBindings.Add("Text", dataSetJoueur, "Joueur.NumeroMaillot");
            CB_EquipeJoueur.DataBindings.Add("SelectedItem", dataSetJoueur, "Joueur.nomequipe");
            CB_PosJoueur.DataBindings.Add("SelectedItem", dataSetJoueur, "Joueur.PositionJoueur");
        }
        private void UnbindTB()
        {
            TB_Url.DataBindings.Clear();
            TB_NumJoueur.DataBindings.Clear();
            TB_NumJoueur.Clear();
            TB_NomJoueur.DataBindings.Clear();
            TB_NomJoueur.Clear();
            TB_PrenomJoueur.DataBindings.Clear();
            TB_PrenomJoueur.Clear();
            DTP_DateNaissance.DataBindings.Clear();
            DTP_DateNaissance.Value = DateTime.Now;
            TB_NumMaillot.DataBindings.Clear();
            TB_NumMaillot.Clear();
            CB_EquipeJoueur.DataBindings.Clear();
            CB_EquipeJoueur.ResetText();
            CB_PosJoueur.DataBindings.Clear();
            CB_PosJoueur.ResetText();
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
        private void Form_Statistiques_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
    }
}
