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
        private void SaveSettings()
        {
            Properties.Settings.Default.Form_EquipeSize = this.Size;
            Properties.Settings.Default.Form_EquipeLocation = this.Location;
        }
        private void LoadSettings()
        {
            this.Size = Properties.Settings.Default.Form_EquipeSize;
            this.Location = Properties.Settings.Default.Form_EquipeLocation;
        }

        private void Form_Equipe_Load(object sender, EventArgs e)
        {
            FB_AjouterEquipe.Select();
            LoadSettings();
            // On appelle la form de connection
            Form_Connection connection = new Form_Connection(oracon, maBelleConnection);
            connection.Text = "Connection";
            connection.ShowDialog();
            if (oracon.State == ConnectionState.Open)
            {
                // On rempli le DGV
                LoadDGV();
                this.Text = "Équipes"; // Set le nom de la form
                PB_Equipe.SizeMode = PictureBoxSizeMode.StretchImage; // Met le picturebox en mode "stretch"
                LoadCBDivision();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas de OracleConnection active", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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
            try
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
                if (divisionDGV == "Toutes")
                {
                    oraSelect.CommandText = "SELECT NomEquipe, DateIntro as DateIntroLigue, d.NOMDIVISION, Ville FROM Equipe E " +
                        "inner join Division D on D.NomDivision = E.NOMDIVISION ";
                }
                else
                {
                    divisionDGV += "'";
                    oraSelect.CommandText = "SELECT NomEquipe, DateIntro as DateIntroLigue, d.NOMDIVISION, Ville FROM Equipe E " +
                                        "inner join Division D on D.NomDivision = E.NOMDIVISION " +
                                        "WHERE e.nomDivision = '" + divisionDGV;
                }


                oraAdapter.Fill(dataSetEquipe, "tableFormEquipe");
                DGV_Equipes.DataSource = dataSetEquipe.Tables[0];
                SetDGVLargeurColonne();
                if (lastIndex > -1 && DGV_Equipes.Rows.Count > 0)
                    DGV_Equipes.Rows[Math.Min(lastIndex, DGV_Equipes.Rows.Count - 1)].Selected = true;

                updateControls();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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
                FB_ModifierEquipe.Enabled = true;
                FB_SupprimerEquipe.Enabled = true;
            }
            else
            {
                FB_ModifierEquipe.Enabled = false;
                FB_SupprimerEquipe.Enabled = false;
            }
        }
        private void Top3()
        {
            Form_Top3 Top3 = new Form_Top3(oracon, maBelleConnection);
            Top3.Text = "Top 3";
            Top3.ShowDialog();
        }
        private void BTN_Top5_Click(object sender, EventArgs e)
        {
            Top3();
        }
        private void Classement()
        {
            Form_Classement classement = new Form_Classement(oracon, maBelleConnection);
            classement.Text = "Classement des équipes";
            classement.ShowDialog();
        }
        private void BTN_Classement_Click(object sender, EventArgs e)
        {
            Classement();
        }
        private void Ajouter()
        {
            Form_Ajouter_Equipe aEquipe = new Form_Ajouter_Equipe(oracon, maBelleConnection);
            aEquipe.Text = "Ajouter une équipe";
            if (aEquipe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "insert into Equipe (NomEquipe,DateIntro,Logo,NomDivision,Ville)" +
                    " VALUES(:NomEquipe,:DateIntroLigue,:LogoEquipe,:DivisionEquipe,:VilleEquipe)";
                try
                {

                    OracleCommand oraAjout = new OracleCommand(sql, oracon);

                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaDateIntroLigue = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParaLogoEquipe = new OracleParameter(":LogoEquipe", OracleDbType.Blob);
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);

                    OraParaNomEquipe.Value = aEquipe.nomEquipe;
                    OraParaDateIntroLigue.Value = DateTime.Parse(aEquipe.dateIntroLigue);
                    OraParaLogoEquipe.Value = null;
                    OraParaDivEquipe.Value = aEquipe.divisionEquipe;
                    OraParaVilleEquipe.Value = aEquipe.villeEquipe;

                    if (aEquipe.image != null)
                    {
                        OraParaLogoEquipe.Value = aEquipe.image;
                    }

                    oraAjout.Parameters.Add(OraParaNomEquipe);
                    oraAjout.Parameters.Add(OraParaDateIntroLigue);
                    oraAjout.Parameters.Add(OraParaLogoEquipe);
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
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter();
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
        private void Modifier()
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
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Modifier();
        }
        private void Supprimer()
        {
            if (MessageBox.Show("Voulez-vous vraiment effacer cette entrée ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void CallFormJoueur()
        {
            Form_Joueurs joueur = new Form_Joueurs(oracon, maBelleConnection, DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString());
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
            SaveSettings();
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Equipes_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void Match()
        {
            Form_Matchs match = new Form_Matchs(oracon, maBelleConnection);
            match.Text = "Matchs";
            match.ShowDialog();
        }
        private void BTN_Matchs_Click(object sender, EventArgs e)
        {
            Match();
        }

        private void CB_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }
        private void Division()
        {
            Form_Divisions div = new Form_Divisions(oracon, maBelleConnection);
            div.Text = "Divisions";
            this.Hide();
            div.callBackForm = this;
            div.ShowDialog();
            LoadDGV();
        }
        private void BTN_Divisions_Click(object sender, EventArgs e)
        {
            Division();
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
            BTN_Ok_Click(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_APropos propos = new Form_APropos();
            propos.Text = "À Propos";
            this.Hide();
            propos.callBackForm = this;
            propos.ShowDialog();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Ajouter_Click(sender, e);
        }

        private void modifierMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Modifier_Click(sender, e);
        }

        private void supprimerMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Supprimer_Click(sender, e);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Ok_Click(sender, e);
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Matchs_Click(sender, e);
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Divisions_Click(sender, e);
        }

        private void classementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Classement_Click(sender, e);
        }

        private void top3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Top5_Click(sender, e);
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BTN_Ok_Click(sender, e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Q))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            if (keyData == (Keys.Control | Keys.A))
                Ajouter();
            if (keyData == (Keys.Control | Keys.M))
                Modifier();
            if (keyData == (Keys.Control | Keys.S))
                Supprimer();
            if (keyData == (Keys.Control | Keys.Shift | Keys.D))
                Division();
            if (keyData == (Keys.Control | Keys.Shift | Keys.M))
                Match();
            if (keyData == (Keys.Control | Keys.Shift | Keys.C))
                Classement();
            if (keyData == (Keys.Control | Keys.Shift | Keys.J))
                CallFormJoueur();
            if (keyData == (Keys.Control | Keys.Shift | Keys.T))
                Top3();
            if (keyData == Keys.F1)
                MessageBox.Show("Voici les touches ayant un racourci \n" +
                                "F1- Aide \n" +
                                "Ctrl+Q- Quitter \n" +
                                "Ctrl+A - Ajouter une équipe \n" +
                                "Ctrl+M - Modifier l'équipe sélectionnée\n" +
                                "Ctrl+S - Supprimer l'équipe sélectionnée\n" +
                                "Ctrl+Shift+D - Page division\n" +
                                "Ctrl+Shift+M - Page match\n" +
                                "Ctrl+Shift+C - Page classement\n" +
                                "Ctrl+Shift+T - Page top3" +
                                "Ctrl+Shift+J - Page joueur", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void matchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Match();
        }

        private void divisionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Division();
        }

        private void classementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Classement();
        }

        private void top3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Top3();
        }

        private void joueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFormJoueur();
        }

        private void quitterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}