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
using System.Text.RegularExpressions;

namespace TPFinal
{
    public partial class Form_Ajouter_Division : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        public Form callBackForm = null;
        public Form_Ajouter_Division(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }
        public string nomDivision
        {
            get
            {
                return TB_NomDivision.Text;
            }
            set
            {
                TB_NomDivision.Text = value;
            }
        }
        public string dateCreation
        {
            get
            {
                return DTP_DateCreation.Value.ToShortDateString();
            }
            set
            {
                DTP_DateCreation.Value = DateTime.Parse(value);
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TB_NomDivision.Text, @"^[a-zA-Z]+$"))
                DialogResult = System.Windows.Forms.DialogResult.OK;
            else
            {
                MessageBox.Show("Le nom de la division doit être seulement composé de lettres et ne doit pas être vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_NomDivision.Text = "";
            }
        }

        private void DTP_DateCreation_ValueChanged(object sender, EventArgs e)
        {
            if (DTP_DateCreation.Value > DateTime.Now)
            {
                MessageBox.Show("Vous devez entrer une date égale ou antérieure à aujourd'hui!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP_DateCreation.Value = DateTime.Now;
            }
        }

        private void Form_Ajouter_Division_Load(object sender, EventArgs e)
        {
            TB_NomDivision.Select();
        }

        private void FB_Cancel_MouseEnter(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = true;
        }

        private void PB_Fermer_Gif_MouseDown(object sender, MouseEventArgs e)
        {           
            FB_Fermer.BackgroundImage = Properties.Resources.ICON_Fermer_Click;
            PB_Fermer_Gif.Visible = false;
            DialogResult = DialogResult.Cancel;
        }

        private void PB_Fermer_Gif_MouseLeave(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = false;
        }
    }
}
