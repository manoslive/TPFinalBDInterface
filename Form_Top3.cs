﻿using System;
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
    public partial class Form_Top3 : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        private DataSet dataSetTop3 = new DataSet();
        public Form_Top3(OracleConnection connectionoracle, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connectionoracle;
            connection = maBelleConnection;
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.Form_Top3Size = this.Size;
            Properties.Settings.Default.Form_Top3Location = this.Location;
            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
            this.Size = Properties.Settings.Default.Form_Top3Size;
            this.Location = Properties.Settings.Default.Form_Top3Location;
        }
        private void Form_Top3_Load(object sender, EventArgs e)
        {
            LoadSettings();
            RemplirTop3Photos();
            RemplirTop3Labels();
            if (DGV_Top3.Rows.Count >= 3)
            {
                RemplirTop3Labels();
                RemplirTop3Photos();
            }
            else
                MessageBox.Show("Vous devez avoir 3 joueurs avec des statistiques " +
                                "pour pouvoir afficher un top3", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RemplirTop3Labels()
        {
            string sqlNomJoueur = "SELECT NomJoueur, Photo FROM StatsJoueur where ROWNUM <=3";
            OracleCommand oraSelect = oracon.CreateCommand();
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            oraSelect.CommandText = sqlNomJoueur;
            oraAdapter.Fill(dataSetTop3, "tableFormTop3");
            DGV_Top3.DataSource = dataSetTop3.Tables[0];



            if (DGV_Top3.Rows.Count >= 3)
            {
                LB_Top1.Text = DGV_Top3.Rows[0].Cells[0].Value.ToString();
                LB_Top2.Text = DGV_Top3.Rows[1].Cells[0].Value.ToString();
                LB_Top3.Text = DGV_Top3.Rows[2].Cells[0].Value.ToString();
                LB_Top1.Visible = true;
                LB_Top2.Visible = true;
                LB_Top3.Visible = true;
            }
        }

        private void RemplirTop3Photos()
        {
            if (DGV_Top3.Rows.Count >= 3)
            {
                PB_Top1.ImageLocation = DGV_Top3.Rows[0].Cells[1].Value.ToString();
                PB_Top2.ImageLocation = DGV_Top3.Rows[1].Cells[1].Value.ToString();
                PB_Top3.ImageLocation = DGV_Top3.Rows[2].Cells[1].Value.ToString();
            }

            PB_Top1.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Top2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Top3.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void Form_Top3_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
