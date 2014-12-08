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
using System.Text.RegularExpressions;

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
                return TB_ScoreReceveur.Text;
            }
            set
            {
                TB_ScoreReceveur.Text = value;
            }
        }
        public string scoreVisiteur
        {
            get
            {
                return TB_ScoreVisiteur.Text;
            }
            set
            {
                TB_ScoreVisiteur.Text = value;

            }
        }

        private void VerifScoreValide(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Form_Ajouter_Match_Load(object sender, EventArgs e)
        {
            CB_EquipeHome.Select();
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

        private void TB_Lieu_TextChanged(object sender, EventArgs e)
        {
            VerifCases();
            if (!Regex.IsMatch(TB_Lieu.Text, @"^[a-zA-Z]+$"))
                TB_Lieu.Text = "";
        }

        private void DTP_DateRencontre_ValueChanged(object sender, EventArgs e)
        {
            if (DTP_DateRencontre.Value > DateTime.Now)
                DTP_DateRencontre.Value = DateTime.Now;
        }

        private void VerifCases()
        {
            if (TB_Lieu.Text != "" && CB_EquipeAway.Text != "" && CB_EquipeHome.Text != "" && TB_ScoreReceveur.Text != "" && TB_ScoreVisiteur.Text != "")
                BTN_Ajouter.Enabled = true;
            else
                BTN_Ajouter.Enabled = false;
        }
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CB_EquipeAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifCases();
        }

        private void CB_EquipeHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifCases();
        }

        private void TB_ScoreVisiteur_TextChanged(object sender, EventArgs e)
        {
            VerifCases();
            if (!Regex.IsMatch(TB_ScoreVisiteur.Text, @"^[0-9]+$"))
                TB_ScoreVisiteur.Text = "";

        }

        private void TB_ScoreReceveur_TextChanged(object sender, EventArgs e)
        {
            VerifCases();
            if (!Regex.IsMatch(TB_ScoreReceveur.Text, @"^[0-9]+$"))
                TB_ScoreReceveur.Text = "";
        }
    }
}
