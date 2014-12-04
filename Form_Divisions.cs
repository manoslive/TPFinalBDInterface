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
                BTN_Modifier.Enabled = true;
                BTN_Supprimer.Enabled = true;
            }
            else
            {
                BTN_Modifier.Enabled = false;
                BTN_Supprimer.Enabled = false;
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
            Form_Ajouter_Division Modifier = new Form_Ajouter_Division(oracon, connection);
            Modifier.nomDivision = DGV_Divisions.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.dateCreation = DGV_Divisions.SelectedRows[0].Cells[1].Value.ToString();
            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string sqlModif = "Update Division set NomDivision =:NomDivision, DateCreation =:DateCreation " +
                                      "where NomDivision =:NomDivision2";

                    OracleCommand oraUpdate = new OracleCommand(sqlModif, oracon);

                    OracleParameter paramNomDivision = new OracleParameter(":NomDivision", OracleDbType.Varchar2, 40);
                    OracleParameter paramDateCreation = new OracleParameter(":DateCreation", OracleDbType.Date);
                    OracleParameter paramNomDivision2 = new OracleParameter(":NomDivision2", OracleDbType.Varchar2, 40);

                    paramNomDivision.Value = Modifier.nomDivision;
                    paramDateCreation.Value = DateTime.Parse(Modifier.dateCreation);
                    paramNomDivision2.Value = DGV_Divisions.SelectedRows[0].Cells[0].Value.ToString();


                    oraUpdate.Parameters.Add(paramNomDivision);
                    oraUpdate.Parameters.Add(paramDateCreation);
                    oraUpdate.Parameters.Add(paramNomDivision2);

                    oraUpdate.ExecuteNonQuery();

                    LoadDGV();
                }

                catch (OracleException ex)
                {
                    if (ex.Number == 2292)
                    {
                        MessageBox.Show("Le nom de la division ne peut etre modifié si elle contient des équipes.", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Voulez-vous vraiment effacer cette entrée ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK);
            {
                try
                {
                    OracleParameter paramNomDivision = new OracleParameter(":NomDivision", OracleDbType.Varchar2, 40);
                    paramNomDivision.Value = DGV_Divisions.SelectedRows[0].Cells[0].Value.ToString();
                    string sqlDelete = "Delete from Division Where NomDivision =:paramNomDivision";
                    OracleCommand oraDelete = new OracleCommand(sqlDelete, oracon);

                    oraDelete.Parameters.Add(paramNomDivision);
                    oraDelete.ExecuteNonQuery();
                    LoadDGV();
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 2292)
                    {
                        MessageBox.Show("La division ne doit pas contenir d'équipe.", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}