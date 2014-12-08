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
    public partial class Form_Classement : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        private DataSet dataSetClassement = new DataSet();
        public Form callBackForm = null;
        public Form_Classement(OracleConnection laConnection, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = laConnection;
            connection = maBelleConnection;
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.Form_ClassementSize = this.Size;
            Properties.Settings.Default.Form_ClassementLocation = this.Location;
            Properties.Settings.Default.Form_Classement_CouleurForm = this.BackColor;
            Properties.Settings.Default.Form_Classement_Police = this.Font;
            Properties.Settings.Default.Form_Classement_CouleurPolice = this.ForeColor;
            Properties.Settings.Default.Form_Classement_DGVPolice = this.DGV_Classement.Font;
            Properties.Settings.Default.Form_Classement_DGVCouleurPolice = this.DGV_Classement.ForeColor;
            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
            this.Size = Properties.Settings.Default.Form_ClassementSize;
            this.Location = Properties.Settings.Default.Form_ClassementLocation;
            this.BackColor = Properties.Settings.Default.Form_Classement_CouleurForm;
            this.Font = Properties.Settings.Default.Form_Classement_Police;
            this.ForeColor = Properties.Settings.Default.Form_Classement_CouleurPolice;
            this.DGV_Classement.Font = Properties.Settings.Default.Form_Classement_DGVPolice;
            this.DGV_Classement.ForeColor = Properties.Settings.Default.Form_Classement_DGVCouleurPolice;
        }
        private void LoadDGV()
        {
            string divisions = null;
            DGV_Classement.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Classement.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Classement.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            dataSetClassement.Clear(); // Vide le dataset afin de ne pas avoir de doublons

            int lastIndex = -1;
            if (DGV_Classement.SelectedRows.Count > 0)
                lastIndex = DGV_Classement.SelectedRows[0].Index;
            OracleCommand oraSelect = oracon.CreateCommand();
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);

            divisions = CB_Division.Text;
            if (divisions != "Est" && divisions != "Ouest")
                divisions = "Est' or nomdivision='Ouest'";
            else
                divisions += "'";
            oraSelect.CommandText = "SELECT * from classement " + 
                                    "where nomdivision= '" + divisions ;
            oraAdapter.Fill(dataSetClassement, "tableclassement");
            DGV_Classement.DataSource = dataSetClassement.Tables[0];
            // SetDGVLargeurColonne();
            if (lastIndex > -1 && DGV_Classement.Rows.Count > 0)
                DGV_Classement.Rows[Math.Min(lastIndex, DGV_Classement.Rows.Count - 1)].Selected = true;
        }

        private void Form_Classement_Load(object sender, EventArgs e)
        {
            CB_Division.Select();
            LoadSettings();
            LoadDGV();
            LoadCBDivision();
        }

        private void LoadCBDivision()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomDivision FROM division";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_Division.Items.Add(oraReader.GetString(0));
                }
                oraReader.Close();
            }
            CB_Division.SelectedIndex = 0;
        }

        private void CB_Division_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadDGV();
        }

        private void Form_Classement_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            LoadDGV();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_APropos propos = new Form_APropos();
            propos.Text = "À Propos";
            this.Hide();
            propos.callBackForm = this;
            propos.ShowDialog();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Preferences preferences = new Form_Preferences(true, Properties.Settings.Default.Form_Classement_Police, Properties.Settings.Default.Form_Classement_CouleurPolice, Properties.Settings.Default.Form_Classement_CouleurForm, Properties.Settings.Default.Form_Classement_DGVPolice, Properties.Settings.Default.Form_Classement_DGVCouleurPolice);
            this.Enabled = false;
            preferences.ShowDialog();
            this.Enabled = true;
            modificationPreferences();
        }
        private void modificationPreferences()
        {
            SaveSettings();
            Properties.Settings.Default.Form_Classement_CouleurForm = Properties.Settings.Default.Preferences_CouleurForm;
            Properties.Settings.Default.Form_Classement_Police = Properties.Settings.Default.Preferences_Police;
            Properties.Settings.Default.Form_Classement_CouleurPolice = Properties.Settings.Default.Preferences_CouleurPolice;
            Properties.Settings.Default.Form_Classement_DGVPolice = Properties.Settings.Default.Preferences_DGVPolice;
            Properties.Settings.Default.Form_Classement_DGVCouleurPolice = Properties.Settings.Default.Preferences_DGVCouleurPolice;
            LoadSettings();
        }
    }
}
