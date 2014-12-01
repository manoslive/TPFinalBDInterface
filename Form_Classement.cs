﻿using System;
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
            string classementDGV = null;
            DGV_Classement.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Classement.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Classement.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            dataSetClassement.Clear(); // Vide le dataset afin de ne pas avoir de doublons
            int lastIndex = -1;
            if (DGV_Classement.SelectedRows.Count > 0)
                lastIndex = DGV_Classement.SelectedRows[0].Index;
            OracleCommand oraSelect = oracon.CreateCommand();
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);

            classementDGV = DGV_Classement.Text;
            if (classementDGV != "Est" && classementDGV != "Ouest")
                classementDGV = "Est' or e.nomdivision='Ouest'";
            else
                classementDGV += "'";
            oraSelect.CommandText = "SELECT NomEquipe, DateIntro as DateIntroLigue, d.NOMDIVISION, Ville FROM Equipe E " +
                                    "inner join Division D on D.NomDivision = E.NOMDIVISION " +
                                    "WHERE e.nomDivision = '" + classementDGV;
            oraAdapter.Fill(dataSetClassement, "tableFormEquipe");
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
    }
}
