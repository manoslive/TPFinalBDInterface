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
    public partial class Form_Ajouter_Stats : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        public string equipeHome = null;
        public string equipeVisiteur = null;
        public Form callBackForm = null;
        public Form_Ajouter_Stats(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }
        public string numJoueur
        {
            get
            {
                return CB_NumJoueur.Text;
            }
            set
            {
                CB_NumJoueur.Text = value;
            }
        }
        public string numMatch
        {
            get
            {
                return TB_NumeroMatch.Text;
            }
            set
            {
                TB_NumeroMatch.Text = value;
            }
        }
        public string nbButs
        {
            get
            {
                return TB_NbButs.Text;
            }
            set
            {
                TB_NbButs.Text = value;
            }
        }
        public string nbPasses
        {
            get
            {
                return TB_NbPasses.Text;
            }
            set
            {
                TB_NbPasses.Text = value;
            }
        }
        public string tempsPunition
        {
            get
            {
                return TB_TempsPunition.Text;
            }
            set
            {
                TB_TempsPunition.Text = value;
            }
        }

        private void ValidationChamps(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_Ajouter_Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Ajouter_Stats_Load(object sender, EventArgs e)
        {
            try
            {
                OracleCommand oraSelect = oracon.CreateCommand();
                oraSelect.CommandText = "SELECT NomJoueur FROM FicheJoueur where NomEquipe = :equipeHome or EquipeJoueur = :equipeVisiteur";
                OracleParameter OraParaEquipeHome = new OracleParameter(":equipeHome", OracleDbType.Varchar2, 40);
                OracleParameter OraParaEquipeVisiteur = new OracleParameter(":equipeVisiteur", OracleDbType.Varchar2, 40);

                OraParaEquipeHome.Value = equipeHome;
                OraParaEquipeVisiteur.Value = equipeVisiteur;
                oraSelect.Parameters.Add(OraParaEquipeHome);
                oraSelect.Parameters.Add(OraParaEquipeVisiteur);

                using (OracleDataReader oraReader = oraSelect.ExecuteReader())
                {
                    while (oraReader.Read())
                    {
                        CB_NumJoueur.Items.Add(oraReader.GetInt32(0));
                    }
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {

        }
    }
}
