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
    public partial class Form_Calendrier_Matchs : Form
    {
        public string numeroMatch = null;
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        private DataSet dateMatch = null;
        public Form callBackForm = null;
        private DateTime Date = DateTime.Today;
        public Form_Calendrier_Matchs(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.Form_CalendrierSize = this.Size;
            Properties.Settings.Default.Form_CalendrierLocation = this.Location;
            Properties.Settings.Default.Form_Calendrier_CouleurForm = this.BackColor;
            Properties.Settings.Default.Form_Calendrier_Police = this.Font;
            Properties.Settings.Default.Form_Calendrier_CouleurPolice = this.ForeColor;
            Properties.Settings.Default.Form_Calendrier_DGVPolice = this.DGV_CalendierMatch.Font;
            Properties.Settings.Default.Form_Calendrier_DGVCouleurPolice = this.DGV_CalendierMatch.ForeColor;
            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
            this.Size = Properties.Settings.Default.Form_CalendrierSize;
            this.Location = Properties.Settings.Default.Form_CalendrierLocation;
            this.BackColor = Properties.Settings.Default.Form_Calendrier_CouleurForm;
            this.Font = Properties.Settings.Default.Form_Calendrier_Police;
            this.ForeColor = Properties.Settings.Default.Form_Calendrier_CouleurPolice;
            this.DGV_CalendierMatch.Font = Properties.Settings.Default.Form_Calendrier_DGVPolice;
            this.DGV_CalendierMatch.ForeColor = Properties.Settings.Default.Form_Calendrier_DGVCouleurPolice;
        }
        private void Form_Calendrier_Matchs_Load(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Select();
            LoadSettings();
            LoadDGV();
            SetDGVLargeurColonne();
        }

        private void Form_Calendrier_Matchs_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void LoadDGV()
        {
            try
            {
                OracleCommand oraSelect = oracon.CreateCommand();
                oraSelect.CommandText = "Select * From Match where DATERECONTRE = :Daterencontre";

                OracleParameter OraParaDateRencontre = new OracleParameter(":Daterencontre", OracleDbType.Date);
                OraParaDateRencontre.Value = Date;
                oraSelect.Parameters.Add(OraParaDateRencontre);

                OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                dateMatch = new DataSet();
                oraAdapter.Fill(dateMatch);
                DGV_CalendierMatch.DataSource = dateMatch.Tables[0];

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Calendrier_Match_DateChanged(object sender, DateRangeEventArgs e)
        {
            Date = Calendrier_Match.SelectionRange.Start;
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

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_APropos propos = new Form_APropos();
            propos.Text = "À Propos";
            this.Hide();
            propos.callBackForm = this;
            propos.ShowDialog();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Preferences preferences = new Form_Preferences(true, Properties.Settings.Default.Form_Calendrier_Police, Properties.Settings.Default.Form_Calendrier_CouleurPolice, Properties.Settings.Default.Form_Calendrier_CouleurForm, Properties.Settings.Default.Form_Calendrier_DGVPolice, Properties.Settings.Default.Form_Calendrier_DGVCouleurPolice);
            this.Enabled = false;
            preferences.ShowDialog();
            this.Enabled = true;
            modificationPreferences();
        }
        private void modificationPreferences()
        {
            SaveSettings();
            Properties.Settings.Default.Form_Calendrier_CouleurForm = Properties.Settings.Default.Preferences_CouleurForm;
            Properties.Settings.Default.Form_Calendrier_Police = Properties.Settings.Default.Preferences_Police;
            Properties.Settings.Default.Form_Calendrier_CouleurPolice = Properties.Settings.Default.Preferences_CouleurPolice;
            Properties.Settings.Default.Form_Calendrier_DGVPolice = Properties.Settings.Default.Preferences_DGVPolice;
            Properties.Settings.Default.Form_Calendrier_DGVCouleurPolice = Properties.Settings.Default.Preferences_DGVCouleurPolice;
            LoadSettings();
        }

        private void Form_Calendrier_Matchs_SizeChanged(object sender, EventArgs e)
        {
            SetDGVLargeurColonne();
        }
        private void SetDGVLargeurColonne()
        {
            if(DGV_CalendierMatch.Columns.Count != 0)
            {
                DGV_CalendierMatch.Columns[0].Width = Convert.ToInt32(DGV_CalendierMatch.Size.Width * 0.10);
                DGV_CalendierMatch.Columns[1].Width = Convert.ToInt32(DGV_CalendierMatch.Size.Width * 0.19);
                DGV_CalendierMatch.Columns[2].Width = Convert.ToInt32(DGV_CalendierMatch.Size.Width * 0.19);
                DGV_CalendierMatch.Columns[3].Width = Convert.ToInt32(DGV_CalendierMatch.Size.Width * 0.15);
                DGV_CalendierMatch.Columns[4].Width = Convert.ToInt32(DGV_CalendierMatch.Size.Width * 0.15);
                DGV_CalendierMatch.Columns[5].Width = Convert.ToInt32(DGV_CalendierMatch.Size.Width * 0.10);
                DGV_CalendierMatch.Columns[6].Width = Convert.ToInt32(DGV_CalendierMatch.Size.Width * 0.10);
            }

        }

        private void DGV_CalendierMatch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numeroMatch = DGV_CalendierMatch.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void PB_Fermer_Gif_Click(object sender, EventArgs e)
        {

        }
    }
}
