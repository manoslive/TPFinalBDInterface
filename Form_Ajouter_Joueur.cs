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
using System.Text.RegularExpressions;

namespace TPFinal
{
    public partial class Form_Ajouter_Joueur : Form
    {
        public string equipeDuJoueur = null;
        private OracleConnection oracon = null;
        private MaConnection cConnection = null;
        private DataSet dataSetJoueur = new DataSet();
        public Form callBackForm = null;
        public Form_Ajouter_Joueur(OracleConnection connection, MaConnection maBelleConnection, string equipeEnCours, string numeroJoueurEnCours)
        {
            InitializeComponent();
            oracon = connection;
            cConnection = maBelleConnection;
            equipeDuJoueur = equipeEnCours;
            if (numeroJoueurEnCours != "")
                numeroJoueur = numeroJoueurEnCours;
        }

        public string nomJoueurs
        {
            get
            {
                return TB_NomJoueur.Text;
            }
            set
            {
                TB_NomJoueur.Text = value;
            }
        }
        public string numeroJoueur
        {
            get
            {
                return TB_NumeroJoueur.Text;
            }
            set
            {
                TB_NumeroJoueur.Text = value;
            }
        }

        public string prenomJoueurs
        {
            get
            {
                return TB_PrenomJoueur.Text;
            }
            set
            {
                TB_PrenomJoueur.Text = value;
            }
        }

        public DateTime DDN
        {
            get
            {
                return DTP_DateNaissance.Value;
            }
            set
            {
                DTP_DateNaissance.Value = (value);
            }
        }

        public string maillot
        {
            get
            {
                return TB_NumMaillot.Text;
            }
            set
            {
                TB_NumMaillot.Text = value;
            }
        }

        public string Equipe
        {
            get
            {
                return CB_EquipeJoueur.Text;
            }
            set
            {
                CB_EquipeJoueur.Text = value;
            }
        }

        public string Photo
        {
            get
            {
                return TB_Url.Text;
            }
            set
            {
                TB_Url.Text = value;
            }
        }

        public string Position
        {
            get
            {
                return CB_PosJoueur.Text;
            }
            set
            {
                CB_PosJoueur.Text = value;
            }
        }

        private void Form_Ajouter_Joueur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
            {
                callBackForm.Location = this.Location;
                callBackForm.Show();
            }
        }
        private void LoadCBEquipes()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomEquipe FROM Equipe";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_EquipeJoueur.Items.Add(oraReader.GetString(0));
                }
                oraReader.Close();
            }
        }

        private void Form_Ajouter_Joueur_Load(object sender, EventArgs e)
        {
            CB_EquipeJoueur.Items.Add(equipeDuJoueur);
            CB_EquipeJoueur.SelectedItem = 0;
            TB_NomJoueur.Select();
            if (CB_EquipeJoueur.Items.Count == 0)
            {
                LoadCBEquipes();
            }
        }
        private bool VerifChamps()
        {
            bool estCorrect = false;
            if (TB_NomJoueur.Text != "" && TB_NumMaillot.Text != "" && TB_PrenomJoueur.Text != "" && TB_Url.Text != "" && CB_EquipeJoueur.Text != "" && CB_PosJoueur.Text != "")
            {
                BTN_Ajouter.Enabled = true;
                estCorrect = true;
            }
            else
                BTN_Ajouter.Enabled = false;


            return estCorrect;
        }
        private void DTP_DateNaissance_ValueChanged(object sender, EventArgs e)
        {
            if (DTP_DateNaissance.Value > DateTime.Now)
            {
                MessageBox.Show("Vous devez entrer une date égale ou antérieure à aujourd'hui!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP_DateNaissance.Value = DateTime.Now;
            }
        }

        private void TB_NumMaillot_TextChanged(object sender, EventArgs e)
        {
            VerifChamps();
            if (!Regex.IsMatch(TB_NumMaillot.Text, @"^[0-9]+$"))
                TB_NumMaillot.Text = "";
        }

        private void TB_PrenomJoueur_TextChanged(object sender, EventArgs e)
        {
            VerifChamps();
            if (!Regex.IsMatch(TB_PrenomJoueur.Text, @"^[a-zA-Z]+$"))
                TB_PrenomJoueur.Text = "";
        }

        private void TB_NomJoueur_TextChanged(object sender, EventArgs e)
        {
            VerifChamps();
            if (!Regex.IsMatch(TB_NomJoueur.Text, @"^[a-zA-Z]+$"))
                TB_NomJoueur.Text = "";
        }

        private void CB_EquipeJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifChamps();
        }

        private void CB_PosJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifChamps();
        }

        private void TB_Url_TextChanged(object sender, EventArgs e)
        {
            VerifChamps();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
