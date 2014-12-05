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
    public partial class Form_Divisions : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        public Form callBackForm = null;
        public DataSet divisionDataSet = null;
        public Form_Divisions(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }
        private void LoadDGV()
        {

            DGV_Divisions.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Divisions.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Divisions.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            int lastIndex = -1;
            if (DGV_Divisions.SelectedRows.Count > 0) lastIndex = DGV_Divisions.SelectedRows[0].Index;

            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomDivision, DateCreation FROM Division";

            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            divisionDataSet = new DataSet();
            oraAdapter.Fill(divisionDataSet);
            DGV_Divisions.DataSource = divisionDataSet.Tables[0];

            if (lastIndex > -1 && DGV_Divisions.Rows.Count > 0) DGV_Divisions.Rows[Math.Min(lastIndex, DGV_Divisions.Rows.Count - 1)].Selected = true;
            MiseAJourControles();
        }

        private void Form_Divisions_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        private void MiseAJourControles()
        {
            if (DGV_Divisions.RowCount > 0)
            {
                FB_ModifierDivision.Enabled = true;
                FB_SupprimerDivision.Enabled = true;
            }
            else
            {
                FB_ModifierDivision.Enabled = false;
                FB_SupprimerDivision.Enabled = false;
            }
        }

        private void DGV_Divisions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // Faire un lien avec la form équipe avec la division choisie
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Division aDiv = new Form_Ajouter_Division(oracon, connection);
            aDiv.Text = "Ajouter une division";
            if (aDiv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlAjout = "insert into Division (NomDivision,DateCreation)" +
                                  " VALUES(:NomDivision,:DateCreation)";
                try
                {
                    OracleParameter OraParaNomDiv = new OracleParameter(":NomDivision", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateCreation = new OracleParameter(":DateCreation", OracleDbType.Date);

                    OraParaNomDiv.Value = aDiv.nomDivision;
                    OraParamDateCreation.Value = DateTime.Parse(aDiv.dateCreation);

                    OracleCommand oraAjout = new OracleCommand(sqlAjout, oracon);

                    oraAjout.Parameters.Add(OraParaNomDiv);
                    oraAjout.Parameters.Add(OraParamDateCreation);

                    oraAjout.ExecuteNonQuery();

                    LoadDGV();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void Form_Divisions_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
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