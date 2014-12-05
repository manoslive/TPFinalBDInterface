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
        }
        private void LoadSettings()
        {
            this.Size = Properties.Settings.Default.Form_CalendrierSize;
            this.Location = Properties.Settings.Default.Form_CalendrierLocation;
        }
        private void Form_Calendrier_Matchs_Load(object sender, EventArgs e)
        {
            LoadSettings();
            LoadDGV();
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
    }
}
