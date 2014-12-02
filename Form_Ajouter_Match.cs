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
    public partial class Form_Ajouter_Match : Form
    {
        public OracleConnection oracon = null;
        private MaConnection maConnection = null;
        public Form callBackForm = null;
        private DataSet ajouterMatchDataSet = new DataSet();
        public Form_Ajouter_Match(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            maConnection = maBelleConnection;
        }

        private void Form_Ajouter_Match_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
        public string numeroMatch
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
        public string equipeHome
        {
            get
            {
                return CB_EquipeHome.Text;
            }
            set
            {
                CB_EquipeHome.Text = value;
            }
        }
        public string equipeVisiteur
        {
            get
            {
                return CB_EquipeAway.Text;
            }
            set
            {
                CB_EquipeAway.Text = value;
            }
        }
        public string dateRencontre
        {
            get
            {
                return DTP_DateRencontre.Value.ToShortDateString();
            }
            set
            {
                DTP_DateRencontre.Value = DateTime.Parse(value);
            }
        }
        public string lieuRencontre
        {
            get
            {
                return TB_Lieu.Text;
            }
            set
            {
                TB_Lieu.Text = value;
            }
        }
        public string scoreHome
        {
            get
            {
                return TB_ScoreHome.Text;
            }
            set
            {
                TB_ScoreHome.Text = value;
            }
        }
        public string scoreVisiteur
        {
            get
            {
                return TB_ScoreAway.Text;
            }
            set
            {
                TB_ScoreAway.Text = value;

            }
        }

        private void VerifScoreValide(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Form_Ajouter_Match_Load(object sender, EventArgs e)
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT nomequipe FROM equipe";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    string items = oraReader.GetString(0);
                    CB_EquipeHome.Items.Add(items);
                    CB_EquipeAway.Items.Add(items);
                }
            }
        }
    }
}
