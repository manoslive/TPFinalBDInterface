using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TPFinal
{
    public partial class Form_Equipes : Form
    {
        private OracleConnection oracon = new OracleConnection(); //connection initialiser ici
        private DataSet dataSetEquipe = new DataSet();
        MaConnection maBelleConnection = new MaConnection();

        public string division = null;
        public Form_Equipes()
        {
            InitializeComponent();
        }

        private void Form_Equipe_Load(object sender, EventArgs e)
        {
            // On appelle la form de connection
            Form_Connection connection = new Form_Connection(oracon, maBelleConnection);
            connection.ShowDialog();
            // On rempli le DGV
            LoadDGV();
        }

        private void LoadDGV()
        {
            int lastIndex = -1;
            if (DGV_Equipes.SelectedRows.Count > 0) 
                lastIndex = DGV_Equipes.SelectedRows[0].Index;
            OracleCommand oraSelect = oracon.CreateCommand();
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            oraSelect.CommandText = "SELECT NomEquipe, DateIntro, d.NOMDIVISION, Ville FROM Equipe E inner join Division D on D.NomDivision = E.NOMDIVISION";
            oraAdapter.Fill(dataSetEquipe, "tableFormEquipe");
            DGV_Equipes.DataSource = dataSetEquipe.Tables[0];

            if (lastIndex > -1 && DGV_Equipes.Rows.Count > 0) 
                DGV_Equipes.Rows[Math.Min(lastIndex, DGV_Equipes.Rows.Count - 1)].Selected = true;

            updateControls();
        }

        private void updateControls() // Met à jours l'état des boutons
        {
            if (DGV_Equipes.RowCount > 0)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
