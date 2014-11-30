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
    public partial class Form_Equipes : Form
    {
        private OracleConnection oracon = new OracleConnection(); //connection initialiser ici
        private DataSet dataSetEquipe = new DataSet();
        MaConnection maBelleConnection = new MaConnection();
        private byte[] image = null;
        public Form_Equipes()
        {
            InitializeComponent();
        }

        private void Form_Equipe_Load(object sender, EventArgs e)
        {
            // On appelle la form de connection
            Form_Connection connection = new Form_Connection(oracon, maBelleConnection);
            connection.Text = "Connection";
            connection.ShowDialog();
            // On rempli le DGV
            LoadDGV();
            this.Text = "Équipes"; // Set le nom de la form
            PB_Equipe.SizeMode = PictureBoxSizeMode.StretchImage; // Met le picturebox en mode "stretch"
        }
   
        private void LoadDGV()
        {
            int lastIndex = -1;
            if (DGV_Equipes.SelectedRows.Count > 0) 
                lastIndex = DGV_Equipes.SelectedRows[0].Index;
            OracleCommand oraSelect = oracon.CreateCommand();
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            oraSelect.CommandText = "SELECT NomEquipe, DateIntro as DateIntroLigue, d.NOMDIVISION, Ville FROM Equipe E inner join Division D on D.NomDivision = E.NOMDIVISION";
            oraAdapter.Fill(dataSetEquipe, "tableFormEquipe");
            DGV_Equipes.DataSource = dataSetEquipe.Tables[0];
            SetDGVLargeurColonne();
            if (lastIndex > -1 && DGV_Equipes.Rows.Count > 0) 
                DGV_Equipes.Rows[Math.Min(lastIndex, DGV_Equipes.Rows.Count - 1)].Selected = true;

            updateControls();
        }

        private void SetDGVLargeurColonne()
        {
            DataGridViewColumn nomEquipe = DGV_Equipes.Columns[0];
            nomEquipe.Width = 80;
            DataGridViewColumn dateIntro = DGV_Equipes.Columns[1];
            dateIntro.Width = 120;
            DataGridViewColumn nomDivision = DGV_Equipes.Columns[2];
            nomDivision.Width = 80;
            DataGridViewColumn ville = DGV_Equipes.Columns[3];
            ville.Width = 85;
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

        private void BTN_Top5_Click(object sender, EventArgs e)
        {
            Form_Top5 Top5 = new Form_Top5();
            Top5.ShowDialog();
        }

        private void BTN_Classement_Click(object sender, EventArgs e)
        {
            Form_Classement classement = new Form_Classement();
            classement.ShowDialog();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Equipe Ajouter = new Form_Ajouter_Equipe(oracon,maBelleConnection);
            Ajouter.Text = "Ajout";
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "insert into Equipe(NomEquipe,DateIntro,Logo,Division,Ville)" + // Rajout de LogoEquipe dans la commande ...incomming crashs bitches !
                    " VALUES(:NomEquipe,:DateIntroLigue,:LogoEquipe,:DivisionEquipe,:VilleEquipe)";
                try
                {

                    OracleCommand oraAjout = new OracleCommand(sql, oracon);

                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateIntro = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParamLogoEquipe = new OracleParameter(":LogoEquipe", OracleDbType.Blob);
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);

                    OraParaNomEquipe.Value = Ajouter.nomEquipe;
                    OraParamDateIntro.Value = DateTime.Parse(Ajouter.dateIntroLigue);
                    OraParamLogoEquipe.Value = null;
                    OraParaDivEquipe.Value = Ajouter.divisionEquipe;
                    OraParaVilleEquipe.Value = Ajouter.villeEquipe;

                    if (Ajouter.image != null)
                    {
                        OraParamLogoEquipe.Value = Ajouter.image;
                    }

                    oraAjout.Parameters.Add(OraParaNomEquipe);
                    oraAjout.Parameters.Add(OraParamDateIntro);
                    oraAjout.Parameters.Add(OraParamLogoEquipe);
                    oraAjout.Parameters.Add(OraParaDivEquipe);
                    oraAjout.Parameters.Add(OraParaVilleEquipe);

                    oraAjout.ExecuteNonQuery();

                    LoadDGV();
                }

                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }    
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Equipes_SelectionChanged(object sender, EventArgs e)
        {
            image = null;
            PB_Equipe.Image = null;

            if (DGV_Equipes.SelectedRows.Count > 0)
            {
                OracleCommand oraImage = oracon.CreateCommand();
                oraImage.CommandText = "SELECT Logo FROM Equipe WHERE NomEquipe=:NomEquipe";
                oraImage.Parameters.Add(new OracleParameter(":NomEquipe", DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString()));
                using (OracleDataReader oraReader = oraImage.ExecuteReader())
                {
                    if (oraReader.Read())
                    {
                        OracleBlob oraBlob = oraReader.GetOracleBlob(0); // à voir l'index du blob
                        if (!oraBlob.IsNull)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                byte[] buffer = new byte[8 * 1024];
                                int read = 0;
                                while ((read = oraBlob.Read(buffer, 0, 8 * 1024)) > 0)
                                {
                                    ms.Write(buffer, 0, read);
                                }
                                image = ms.ToArray();
                                PB_Equipe.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
        }
    }
}
