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

        private void Form_Calendrier_Matchs_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void Form_Calendrier_Matchs_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        }
        private void PB_Fermer_Gif_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void PB_Fermer_Gif_MouseLeave(object sender, EventArgs e)
        {

        }

        private void PB_Fermer_Gif_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
