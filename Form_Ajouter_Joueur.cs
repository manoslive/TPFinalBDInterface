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
    public partial class Form_Ajouter_Joueur : Form
    {
        private OracleConnection oracon = null;
        private MaConnection cConnection = null;
        private DataSet dataSetJoueur = new DataSet();
        public Form callBackForm = null;
        public Form_Ajouter_Joueur(OracleConnection connection, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connection;
            cConnection = maBelleConnection;
        }

        public string nomJoueurs
        {
            get
            {
                return TB_NomJoueur.Text;
            }
            set
            {
                TB_NomJoueur.Text = value;
            }
        }

        public string prenomJoueurs
        {
            get
            {
                return TB_PrenomJoueur.Text;
            }
            set
            {
                TB_PrenomJoueur.Text = value;
            }
        }

        public string DDN
        {
            get
            {
                return DTP_DateNaissance.Value.ToString();
            }
            set
            {
                DTP_DateNaissance.Value = DateTime.Parse(value);
            }
        }

        public string maillot
        {
            get
            {
                return TB_NumMaillot.Text;
            }
            set
            {
                TB_NumMaillot.Text = value;
            }
        }

        public string Equipe
        {
            get
            {
                return CB_EquipeJoueur.Text;
            }
            set
            {
                CB_EquipeJoueur.Text = value;
            }
        }

        public string Photo
        {
            get
            {
                return TB_Url.Text;
            }
            set
            {
                TB_Url.Text = value;
            }
        }

        public string Position
        {
            get
            {
                return CB_PosJoueur.Text;
            }
            set
            {
                CB_PosJoueur.Text = value;
            }
        }

        private void Form_Ajouter_Joueur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
            {
                callBackForm.Location = this.Location;
                callBackForm.Show();
            }
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {

        }

        private void Form_Ajouter_Joueur_Load(object sender, EventArgs e)
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomEquipe FROM Equipe";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_EquipeJoueur.Items.Add(oraReader.GetString(0));
                }
                oraReader.Close();
            }
        }

        private void BTN_Ajouter_Click_1(object sender, EventArgs e)
        {
            string sql = "insert into joueur" +
                             "(nomjoueur, prenomjoueur, datenaissance, numeromaillot, photo, nomequipe, positionjoueur)" +
                             "Values(:Nomjoueurs,:Prenomjoueurs,:datenaissance,:numeromaillot,:Photo,:equipejoueur,:positionjoueur)";
            try
            {
                OracleCommand oraAjout = new OracleCommand(sql, oracon);

                OracleParameter OraParaNomjoueurs = new OracleParameter(":Nomjoueurs", OracleDbType.Varchar2, 40);
                OracleParameter OraParamPrenomjoueurs = new OracleParameter(":Prenomjoueurs", OracleDbType.Varchar2, 40);
                OracleParameter OraParamdatenaissance = new OracleParameter(":datenaissance", OracleDbType.Date);
                OracleParameter OraParanumeromaillot = new OracleParameter(":numeromaillot", OracleDbType.Int32);
                OracleParameter OraParaequipejoueurs = new OracleParameter(":equipejoueur", OracleDbType.Varchar2, 40);
                OracleParameter OraParpositionjoueur = new OracleParameter(":positionjoueur", OracleDbType.Varchar2, 40);
                OracleParameter OraParaPhoto = new OracleParameter(":Photo", OracleDbType.Varchar2, 1500);

                OraParaNomjoueurs.Value = TB_NomJoueur.Text;
                OraParamPrenomjoueurs.Value = TB_PrenomJoueur.Text;
                OraParamdatenaissance.Value = DTP_DateNaissance.Value;
                OraParanumeromaillot.Value = TB_NumMaillot.Text;
                MessageBox.Show(CB_EquipeJoueur.SelectedValue.ToString());
                OraParaequipejoueurs.Value = CB_EquipeJoueur.SelectedValue.ToString();
                OraParpositionjoueur.Value = CB_PosJoueur.SelectedValue.ToString();
                OraParaPhoto.Value = TB_Url.Text;

                oraAjout.Parameters.Add(OraParaNomjoueurs);
                oraAjout.Parameters.Add(OraParamPrenomjoueurs);
                oraAjout.Parameters.Add(OraParamdatenaissance);
                oraAjout.Parameters.Add(OraParanumeromaillot);
                oraAjout.Parameters.Add(OraParaequipejoueurs);
                oraAjout.Parameters.Add(OraParpositionjoueur);
                oraAjout.Parameters.Add(OraParaPhoto);

                oraAjout.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
