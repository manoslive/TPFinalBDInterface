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
        public Form callBackForm = null;
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

        private void LoadDGV()
        {
            string divisionDGV = null;
            DGV_Equipes.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Equipes.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Equipes.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            dataSetEquipe.Clear(); // Vide le dataset afin de ne pas avoir de doublons
            int lastIndex = -1;
            if (DGV_Equipes.SelectedRows.Count > 0)
                lastIndex = DGV_Equipes.SelectedRows[0].Index;
            OracleCommand oraSelect = oracon.CreateCommand();
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            
            divisionDGV = CB_Division.Text;
            if (divisionDGV != "Est" && divisionDGV != "Ouest")
                divisionDGV = "Est' or e.nomdivision='Ouest'";
            else
                divisionDGV += "'";
            oraSelect.CommandText = "SELECT NomEquipe, DateIntro as DateIntroLigue, d.NOMDIVISION, Ville FROM Equipe E "+ 
                                    "inner join Division D on D.NomDivision = E.NOMDIVISION "+
                                    "WHERE e.nomDivision = '" + divisionDGV;
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
            Form_Top5 Top5 = new Form_Top5(oracon, maBelleConnection);
            Top5.Text = "Top 3";
            Top5.ShowDialog();
        }

        private void BTN_Classement_Click(object sender, EventArgs e)
        {
            Form_Classement classement = new Form_Classement(oracon, maBelleConnection);
            classement.Text = "Classement des équipes";
            classement.ShowDialog();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Equipe Ajouter = new Form_Ajouter_Equipe(oracon, maBelleConnection);
            Ajouter.Text = "Ajout d'équipe";
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "insert into Equipe(NomEquipe,DateIntro,Logo,NomDivision,Ville)" + // Rajout de LogoEquipe dans la commande ...incomming crashs bitches !
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

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Equipe Modifier = new Form_Ajouter_Equipe(oracon, maBelleConnection);
            Modifier.Text = "Modification équipe";
            Modifier.nomEquipe = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.dateIntroLigue = DGV_Equipes.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.divisionEquipe = DGV_Equipes.SelectedRows[0].Cells[2].Value.ToString();
            Modifier.villeEquipe = DGV_Equipes.SelectedRows[0].Cells[3].Value.ToString();
            if (image != null)
                Modifier.image = image;

            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlModif = "Update Equipe set NomEquipe =:NomEquipe, DateIntro =:DateIntroLigue, Logo =:LogoEquipe, " +
                        "NomDivision =:DivisionEquipe, Ville =:VilleEquipe where NomEquipe =:NomEquipe2";
                try
                {

                    OracleCommand oraModif = new OracleCommand(sqlModif, oracon);

                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateIntroLigue = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParamLogoEquipe = new OracleParameter(":LogoEquipe", OracleDbType.Blob);  //Ajout
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaNomEquipe2 = new OracleParameter(":NomEquipe2", OracleDbType.Varchar2, 40);

                    OraParaNomEquipe.Value = Modifier.nomEquipe;
                    OraParamDateIntroLigue.Value = DateTime.Parse(Modifier.dateIntroLigue);
                    OraParamLogoEquipe.Value = image;
                    OraParaDivEquipe.Value = Modifier.divisionEquipe;
                    OraParaVilleEquipe.Value = Modifier.villeEquipe;
                    OraParaNomEquipe2.Value = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();

                    if (Modifier.image != null)
                    {
                        OraParamLogoEquipe.Value = Modifier.image;
                    }

                    oraModif.Parameters.Add(OraParaNomEquipe);
                    oraModif.Parameters.Add(OraParamDateIntroLigue);
                    oraModif.Parameters.Add(OraParamLogoEquipe);
                    oraModif.Parameters.Add(OraParaDivEquipe);
                    oraModif.Parameters.Add(OraParaVilleEquipe);
                    oraModif.Parameters.Add(OraParaNomEquipe2);

                    oraModif.ExecuteNonQuery();

                    LoadDGV();

                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment effacer cette entrée ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
            {
                try
                {
                    OracleParameter paramNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    paramNomEquipe.Value = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();
                    string sqlDelete = "Delete from Equipe Where NomEquipe =:paramNomEquipe";
                    OracleCommand oraDelete = new OracleCommand(sqlDelete, oracon);
                    oraDelete.Parameters.Add(paramNomEquipe);
                    oraDelete.ExecuteNonQuery();

                    LoadDGV();
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 2292)
                    {
                        MessageBox.Show("L'équipe contient des joueurs et ne peut pas être effacée", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CallFormJoueur()
        {
            Form_Joueurs joueur = new Form_Joueurs(oracon,maBelleConnection, DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString());
            joueur.Text = "Détail du joueur";
            this.Hide();
            joueur.callBackForm = this;
            joueur.ShowDialog();


        }
        private void DGV_Equipes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CallFormJoueur();
        }

        private void Form_Equipes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Equipes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CallFormJoueur();
        }

        private void BTN_Matchs_Click(object sender, EventArgs e)
        {
            Form_Matchs match = new Form_Matchs(oracon, maBelleConnection);
            match.Text = "Matchs";
            match.ShowDialog();
        }

        private void CB_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}