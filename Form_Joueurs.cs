using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TPFinal
{
    public partial class Form_Joueurs : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        private DataSet dataSetJoueur = new DataSet();
        public Form callBackForm = null;
        private string equipe { get; set; }
        private bool currval { get; set; }
        private string commandeSQL { get; set; }

        public Form_Joueurs(OracleConnection connectionoracle, MaConnection maBelleConnection, string equipeEnCours)
        {
            InitializeComponent();
            oracon = connectionoracle;
            connection = maBelleConnection;
            equipe = equipeEnCours;
            currval = false;
            commandeSQL = null;
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e) // Ouvre la form d'ajout de joueur
        {

        }

        private void RemplirFormulaire()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT * FROM Joueur WHERE nomequipe= :NomEquipe";
            oraSelect.Parameters.Add(new OracleParameter(":NomEquipe", equipe));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect))
            {
                if (dataSetJoueur.Tables.Contains("Joueur"))
                {
                    dataSetJoueur.Tables["Joueur"].Clear();
                }
                oraAdapter.Fill(dataSetJoueur, "Joueur");
                oraAdapter.Dispose();
            }
            if (TB_Url.Text != "")
                PB_Joueur.ImageLocation = TB_Url.Text;

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
                FB_ModifierJoueur.Enabled = false;
                FB_Debut.Enabled = false;
                FB_Fin.Enabled = false;
                FB_Precedent.Enabled = false;
                FB_Suivant.Enabled = false;
                FB_SupprimerJoueur.Enabled = false;
            }
            else
            {
                FB_ModifierJoueur.Enabled = true;
                FB_Debut.Enabled = true;
                FB_Fin.Enabled = true;
                FB_Precedent.Enabled = true;
                FB_Suivant.Enabled = true;
                FB_SupprimerJoueur.Enabled = true;
            }
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Fin_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {

        }
        private void BTN_Precedent_Click(object sender, EventArgs e)
        {

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

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void Form_Joueurs_Load(object sender, EventArgs e)
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomEquipe FROM Equipe";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_EquipeJoueur.Items.Add(oraReader.GetString(0));
                }
            }

            PB_Joueur.SizeMode = PictureBoxSizeMode.StretchImage; // Met le picturebox en mode "stretch"
            MiseAJourFormulaire();
            if (TB_Url.Text != "")
                PB_Joueur.ImageLocation = TB_Url.Text;
        }

        private void MiseAJourFormulaire()
        {
            RemplirFormulaire();
            updateControls();
        }

        private void Form_Joueurs_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Joueurs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                BTN_Suivant_Click(sender, e);
            if (e.KeyCode == Keys.Left)
                BTN_Precedent_Click(sender, e);
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
            DialogResult = DialogResult.Cancel;
        }
    }
}
