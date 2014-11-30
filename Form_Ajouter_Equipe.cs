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
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomDivision FROM Division";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_Division.Items.Add(oraReader.GetString(0));
                }
            }
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
                if (image_ != null) {
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
        public string divisionEquipe
        {
            get
            {
                return CB_Division.Text;
            }
            set
            {
                CB_Division.Text = value;
            }
        }
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
            // Massive Will
            image = null;

            OpenFileDialog fImage = new OpenFileDialog();
            fImage.Title = "selectionner une image";
            fImage.CheckFileExists = true;
            fImage.InitialDirectory = @":C\";
            //fImage.InitialDirectory = Application.StartupPath;
            fImage.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            fImage.FilterIndex = 1;
            fImage.RestoreDirectory = true;

            if (fImage.ShowDialog() == DialogResult.OK)
            {
                image = File.ReadAllBytes(fImage.FileName);
                PB_Equipe.Image = Image.FromFile(fImage.FileName);
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {

        }
    }
}
