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
    public partial class Form_Ajouter_Stats : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        public string equipeHome = null;
        public string equipeVisiteur = null;
        public Form callBackForm = null;
        public bool isModif = false;
        private DataSet ajouterDataSet = new DataSet();
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
                return CB_NumeroJoueur.Text;
            }
            set
            {
                CB_NumeroJoueur.Text = value;
            }
        }
        public string numMatch
        {
            get
            {
                return CB_NumeroMatch.Text;
            }
            set
            {
                CB_NumeroMatch.Text = value;
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
        }

        private void Form_Ajouter_Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Ajouter_Stats_Load(object sender, EventArgs e)
        {
            CB_NumeroMatch.Select();
            RemplirCBMatchPremiereFois();
            TB_NbButs.Enabled = false;
            TB_NbPasses.Enabled = false;
            TB_NbPasses.Text = null;
            TB_NbButs.Text = null;
        }

        private void RemplirTB()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "Select nombrebuts, nombrepasses, tempspunition From Statistiques " +
                                    "where NumeroJoueur=:NumeroJoueur and NumeroMatch=:NumeroMatch";
            oraSelect.Parameters.Add(new OracleParameter(":NumeroJoueur", numJoueur));
            oraSelect.Parameters.Add(new OracleParameter(":NumeroMatch", numMatch));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect))
            {
                if (ajouterDataSet.Tables.Contains("AjoutStats"))
                {
                    ajouterDataSet.Tables["AjoutStats"].Clear();
                }
                oraAdapter.Fill(ajouterDataSet, "AjoutStats");
                oraAdapter.Dispose();
            }
            UpdateLinkTB();
        }
        private void UpdateLinkTB()
        {
            UnbindTB();
            TB_NbButs.DataBindings.Add("Text", ajouterDataSet, "AjoutStats.nombrebuts");
            TB_NbPasses.DataBindings.Add("Text", ajouterDataSet, "AjoutStats.nombrepasses");
            TB_TempsPunition.DataBindings.Add("Text", ajouterDataSet, "AjoutStats.tempspunition");
        }
        private void UnbindTB()
        {
            TB_NbButs.DataBindings.Clear();
            TB_NbButs.Clear();
            TB_NbPasses.DataBindings.Clear();
            TB_NbPasses.Clear();
            TB_TempsPunition.DataBindings.Clear();
            TB_TempsPunition.Clear();
        }

        private void RemplirCBMatchPremiereFois()
        {
            try
            {
                OracleCommand oraSelect = oracon.CreateCommand();
                oraSelect.CommandText = "SELECT NumeroMatch FROM Match " +
                                        "group by NumeroMatch ";

                //OracleParameter OraParaNumJoueur = new OracleParameter(":NumeroJoueur", OracleDbType.Varchar2, 40);
                //OraParaNumJoueur.Value = numJoueur;
                //oraSelect.Parameters.Add(OraParaNumJoueur);
                //oraSelect.CommandType = CommandType.Text;
                using (OracleDataReader oraReader = oraSelect.ExecuteReader())
                {
                    while (oraReader.Read())
                    {
                        CB_NumeroMatch.Items.Add(oraReader.GetInt32(0));
                    }
                    oraReader.Close();
                }
                //oraSelect.ExecuteNonQuery();
                if (CB_NumeroMatch.Items.Count != 0)
                {
                    CB_NumeroMatch.SelectedIndex = 0;
                    RemplirCBJoueur();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void RemplirCBJoueur()
        {
            if (CB_NumeroJoueur.Items.Count != 0)
                CB_NumeroJoueur.Items.Clear();
            try
            {
                string numMatch = CB_NumeroMatch.Text;
                OracleCommand oraSelect = oracon.CreateCommand();
                oraSelect.CommandText = "SELECT NumeroJoueur FROM Match M " +
                                        "inner join joueur j on m.equipereceveur=j.nomequipe " +
                                        "WHERE NumeroMatch=" + numMatch + " UNION " +
                                        "SELECT NumeroJoueur FROM Match M " +
                                        "inner join joueur j on m.equipevisiteur=j.nomequipe " +
                                        "WHERE NumeroMatch=" + numMatch +
                                        " group by NumeroJoueur";
                OracleParameter OraParaNumJoueur = new OracleParameter(":NumeroJoueur", OracleDbType.Varchar2, 40);

                OraParaNumJoueur.Value = numJoueur;
                oraSelect.Parameters.Add(OraParaNumJoueur);

                using (OracleDataReader oraReader = oraSelect.ExecuteReader())
                {
                    while (oraReader.Read())
                    {
                        CB_NumeroJoueur.Items.Add(oraReader.GetInt32(0));
                    }
                }
                if (CB_NumeroJoueur.Items.Count != 0)
                    CB_NumeroJoueur.SelectedIndex = 0;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void RemplirCBMatch()
        {
            try
            {
                OracleCommand oraSelect = oracon.CreateCommand();
                oraSelect.CommandText = "SELECT NumeroMatch FROM FicheJoueur " +
                                        "group by NumeroMatch";
                OracleParameter OraParaNumJoueur = new OracleParameter(":NumeroJoueur", OracleDbType.Varchar2, 40);

                OraParaNumJoueur.Value = numJoueur;
                oraSelect.Parameters.Add(OraParaNumJoueur);

                using (OracleDataReader oraReader = oraSelect.ExecuteReader())
                {
                    while (oraReader.Read())
                    {
                        CB_NumeroMatch.Items.Add(oraReader.GetInt32(0));
                    }
                }
                if (CB_NumeroMatch.Items.Count != 0)
                {
                    CB_NumeroMatch.SelectedIndex = 0;
                    RemplirCBJoueur();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void VerifCases()
        {
            if (CB_NumeroJoueur.Text != "" && CB_NumeroMatch.Text != "" && TB_NbButs.Text != "" && TB_NbPasses.Text != "" && TB_TempsPunition.Text != "")
                FB_Ajouter.Enabled = true;
            else
                FB_Ajouter.Enabled = false;
        }
        private void CB_NumeroMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirCBJoueur();
            if (isModif)
                RemplirTB();
        }

        private void TB_TempsPunition_TextChanged(object sender, EventArgs e)
        {
            VerifCases();
            if (!Regex.IsMatch(TB_TempsPunition.Text, @"^[0-9]+$"))
                TB_TempsPunition.Text = "";

        }

        private void CB_NumeroJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifCases();
            VerifPosition();
            if (isModif)
                RemplirTB();
        }
        private void VerifPosition()
        {
            TB_Position.Text = "";
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT PositionJoueur FROM Joueur " +
                                    "where NumeroJoueur = :NumeroJoueur";
            OracleParameter OraParaNumJoueur = new OracleParameter(":NumeroJoueur", OracleDbType.Varchar2, 40);

            OraParaNumJoueur.Value = numJoueur;
            oraSelect.Parameters.Add(OraParaNumJoueur);
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    TB_Position.Text = oraReader.GetString(0).ToString();
                }
            }
        }
        private void TB_NbPasses_TextChanged(object sender, EventArgs e)
        {
            VerifCases();
            if (!Regex.IsMatch(TB_NbPasses.Text, @"^[0-9]+$"))
                TB_NbPasses.Text = "";
        }

        private void TB_NbButs_TextChanged(object sender, EventArgs e)
        {
            VerifCases();
            if (!Regex.IsMatch(TB_NbButs.Text, @"^[0-9]+$"))
                TB_NbButs.Text = "";
        }

        private void FB_Cancel_MouseEnter(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = true;
        }
        private void PB_Fermer_Gif_MouseLeave(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = false;
        }

        private void PB_Fermer_Gif_MouseDown(object sender, MouseEventArgs e)
        {
            PB_Fermer_Gif.Visible = false;
            FB_Fermer.BackgroundImage = Properties.Resources.ICON_Fermer_Click;
        }

        private void PB_Fermer_Gif_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TB_Position_TextChanged(object sender, EventArgs e)
        {
            if (TB_Position.Text == "Gardien")
            {
                TB_NbButs.Text = "0";
                TB_NbPasses.Text = "0";
                TB_NbButs.Enabled = false;
                TB_NbPasses.Enabled = false;
            }
            else
            {
                TB_NbButs.Enabled = true;
                TB_NbPasses.Enabled = true;
            }
        }
    }
}
