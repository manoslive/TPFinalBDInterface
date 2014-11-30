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
    public partial class Form_Ajouter_Joueur : Form
    {
        private OracleConnection oracon = null;
        private MaConnection cConnection = null;
        private DataSet dataSetJoueur = new DataSet();
        public Form callBackForm = null;
        public Form_Ajouter_Joueur(OracleConnection connection, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connection;
            cConnection = maBelleConnection;
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

        public string DDN
        {
            get
            {
                return DTP_DateNaissance.Value.ToString();
            }
            set
            {
                DTP_DateNaissance.Value = DateTime.Parse(value);
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
            if(callBackForm != null)
            {
                callBackForm.Location = this.Location;
                callBackForm.Show();
            }
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {

        }
    }
}
