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
            LoadDGV();
        }
    }
}
