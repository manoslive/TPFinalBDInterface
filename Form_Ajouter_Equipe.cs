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
using System.Text.RegularExpressions;

namespace TPFinal
{
    public partial class Form_Ajouter_Equipe : Form
    {
        private OracleConnection oracon;
        private MaConnection cConnection;
        public Form_Ajouter_Equipe(OracleConnection connection, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connection;
            cConnection = maBelleConnection;
        }
        private void FormEquipe_Ajouter_Load(object sender, EventArgs e)
        {
            TB_NomEquipe.Select();
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomDivision FROM Division";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_Division.Items.Add(oraReader.GetString(0));
                }
            }
            CB_Division.Text = divisionEquipe;
            PB_Equipe.SizeMode = PictureBoxSizeMode.StretchImage; // Met le picturebox en mode "Stretch"
        }
        private byte[] image_;
        public byte[] image
        {
            get
            {
                return image_;
            }
            set
            {
                image_ = value;
                if (image_ != null)
                {
                    using (MemoryStream ms = new MemoryStream(image_))
                    {
                        PB_Equipe.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        public string nomEquipe
        {
            get
            {
                return TB_NomEquipe.Text;
            }
            set
            {
                TB_NomEquipe.Text = value;
            }
        }
        public string dateIntroLigue
        {
            get
            {
                return DTP_Creation.Value.ToShortDateString();
            }
            set
            {
                DTP_Creation.Value = DateTime.Parse(value);
            }
        }
        public string divisionEquipe;
        public string villeEquipe
        {
            get
            {
                return TB_Ville.Text;
            }
            set
            {
                TB_Ville.Text = value;
            }
        }
        private void BTN_ChargerImage_Click(object sender, EventArgs e)
        {
            image = null;

            OpenFileDialog imageEquipe = new OpenFileDialog();
            imageEquipe.Title = "selectionner une image";
            imageEquipe.CheckFileExists = true;
            imageEquipe.InitialDirectory = @":C\";
            //fImage.InitialDirectory = Application.StartupPath;
            imageEquipe.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            imageEquipe.FilterIndex = 1;
            imageEquipe.RestoreDirectory = true;

            if (imageEquipe.ShowDialog() == DialogResult.OK)
            {
                image = File.ReadAllBytes(imageEquipe.FileName);
                PB_Equipe.Image = Image.FromFile(imageEquipe.FileName);
            }
        }
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TB_NomEquipe.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Le nom de l'équipe doit être seulement composé de lettres et ne doit pas être vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_NomEquipe.Text = "";
            }

            if (!Regex.IsMatch(TB_Ville.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Le nom de la ville doit être seulement composé de lettres et ne doit pas être vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_Ville.Text = "";
            }
            if (DTP_Creation.Value > DateTime.Now)
            {
                MessageBox.Show("Vous devez entrer une date égale ou antérieure à aujourd'hui!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP_Creation.Value = DateTime.Now;
            }

            if (Regex.IsMatch(TB_NomEquipe.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(TB_Ville.Text, @"^[a-zA-Z]+$") && (DTP_Creation.Value <= DateTime.Now) && CB_Division.Text != "")
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void CheckCasesVides()
        {
            if (TB_Ville.Text != "" && TB_NomEquipe.Text != "" && CB_Division.Text != "")
                FB_Ajouter.Enabled = true;
            else
                FB_Ajouter.Enabled = false;
        }
        private void TB_Ville_TextChanged(object sender, EventArgs e)
        {
            CheckCasesVides();
        }

        private void CB_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCasesVides();
        }

        private void TB_NomEquipe_TextChanged(object sender, EventArgs e)
        {
            CheckCasesVides();
        }
        private void FB_Cancel_MouseEnter(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = true;
        }
        private void PB_Fermer_Gif_MouseLeave(object sender, EventArgs e)
        {
            PB_Fermer_Gif.Visible = false;
        }

        private void PB_Fermer_Gif_MouseDown(object sender, MouseEventArgs e)
        {
            PB_Fermer_Gif.Visible = false;
            FB_Fermer.BackgroundImage = Properties.Resources.ICON_Fermer_Click;
        }

        private void PB_Fermer_Gif_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
