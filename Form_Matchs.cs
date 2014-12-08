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
    public partial class Form_Matchs : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        public Form callBackForm = null;
        public DataSet matchDataSet = null;
        public DataSet joueursDataSet = null;
        public Form_Matchs(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.Form_MatchsSize = this.Size;
            Properties.Settings.Default.Form_MatchsLocation = this.Location;
            Properties.Settings.Default.Form_Matchs_CouleurForm=this.BackColor;
            Properties.Settings.Default.Form_Matchs_Police = this.Font;
            Properties.Settings.Default.Form_Matchs_CouleurPolice = this.ForeColor;
            Properties.Settings.Default.Form_Matchs_DGVPolice = this.DGV_Matchs.Font;
            Properties.Settings.Default.Form_Matchs_DGVCouleurPolice = this.DGV_Matchs.ForeColor;
            Properties.Settings.Default.Form_Matchs_DGVPolice = this.DGV_Joueurs.Font;
            Properties.Settings.Default.Form_Matchs_DGVCouleurPolice = this.DGV_Joueurs.ForeColor;
            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
            this.Size = Properties.Settings.Default.Form_MatchsSize;
            this.Location = Properties.Settings.Default.Form_MatchsLocation;
            this.BackColor = Properties.Settings.Default.Form_Matchs_CouleurForm;
            this.Font = Properties.Settings.Default.Form_Matchs_Police;
            this.ForeColor = Properties.Settings.Default.Form_Matchs_CouleurPolice;
            this.DGV_Matchs.Font = Properties.Settings.Default.Form_Matchs_DGVPolice;
            this.DGV_Matchs.ForeColor = Properties.Settings.Default.Form_Matchs_DGVCouleurPolice;
            this.DGV_Joueurs.Font = Properties.Settings.Default.Form_Matchs_DGVPolice;
            this.DGV_Joueurs.ForeColor = Properties.Settings.Default.Form_Matchs_DGVCouleurPolice;
        }
        private void Ajouter()
        {
            Form_Ajouter_Match ajm = new Form_Ajouter_Match(oracon, connection);
            ajm.Text = "Ajout de match";
            ajm.callBackForm = this;
            this.Hide();
            string sqlAjout = null;

            OracleCommand oraCMD = new OracleCommand(sqlAjout, oracon);
            oraCMD.CommandType = CommandType.Text;
            if (ajm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlMatchAjout = "insert into Match (EquipeReceveur,EquipeVisiteur,DateRecontre,LieuRencontre,ScoreFinalReceveur, ScoreFinalVisiteur)" +
                    " VALUES(:EquipeHome,:EquipeVisiteur,:DateRencontre,:Lieu,:scorehome,:scorevisiteur)";

                try
                {
                    OracleCommand oraMatchAjout = new OracleCommand(sqlMatchAjout, oracon);


                    OracleParameter OraParaEquipeHome = new OracleParameter(":EquipeHome", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaEquipeVisiteur = new OracleParameter(":EquipeVisiteur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaDateRencontre = new OracleParameter(":DateRencontre", OracleDbType.Date);
                    OracleParameter OraParaLieu = new OracleParameter(":Lieu", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaScoreHome = new OracleParameter(":ScoreHome", OracleDbType.Int32);
                    OracleParameter OraParaScoreVisiteur = new OracleParameter(":ScoreVisiteur", OracleDbType.Int32);

                    OraParaEquipeHome.Value = ajm.equipeHome;
                    OraParaEquipeVisiteur.Value = ajm.equipeVisiteur;
                    OraParaDateRencontre.Value = DateTime.Parse(ajm.dateRencontre);
                    OraParaLieu.Value = ajm.lieuRencontre;
                    OraParaScoreHome.Value = ajm.scoreHome;
                    OraParaScoreVisiteur.Value = ajm.scoreVisiteur;

                    oraMatchAjout.Parameters.Add(OraParaEquipeHome);
                    oraMatchAjout.Parameters.Add(OraParaEquipeVisiteur);
                    oraMatchAjout.Parameters.Add(OraParaDateRencontre);
                    oraMatchAjout.Parameters.Add(OraParaLieu);
                    oraMatchAjout.Parameters.Add(OraParaScoreHome);
                    oraMatchAjout.Parameters.Add(OraParaScoreVisiteur);

                    oraMatchAjout.ExecuteNonQuery();

                    LoadDGVmatch();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void BTN_AjoutRencontre_Click(object sender, EventArgs e)
        {
            // test
            Ajouter();
        }
        private void LoadDGVmatch()
        {
            DGV_Matchs.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Matchs.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Matchs.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            int lastIndex = -1;
            if (DGV_Matchs.SelectedRows.Count > 0) lastIndex = DGV_Matchs.SelectedRows[0].Index;

            OracleCommand oraSelect = oracon.CreateCommand();
            //oraSelect.CommandText = "SELECT NumeroMatch, EquipeReceveur, EquipeVisiteur, DateRecontre, LieuRencontre, sum(select nombrebuts from fichejoueur) as ScoreFinalReceveur, ScoreFinalVisiteur FROM Match M" +
            //                        "inner join FicheJoueur F on F.NumeroMatch=M.NumeroMatch" +
            //                        "inner join Equipe E on E.NomEquipe=M.EquipeReceveur " +
            //                        "order by NumeroMatch";
            oraSelect.CommandText = "SELECT * FROM Match" + 
                                    " order by numeromatch";
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect); 
            matchDataSet = new DataSet();
            oraAdapter.Fill(matchDataSet);
            DGV_Matchs.DataSource = matchDataSet.Tables[0];

            if (lastIndex > -1 && DGV_Matchs.Rows.Count > 0) DGV_Matchs.Rows[Math.Min(lastIndex, DGV_Matchs.Rows.Count - 1)].Selected = true;
        }
        private void SetDGVLargeurColonne()
        {
            DataGridViewColumn nomEquipe = DGV_Matchs.Columns[0];
            nomEquipe.Width = 80;
            DataGridViewColumn dateIntro = DGV_Matchs.Columns[1];
            dateIntro.Width = 120;
            DataGridViewColumn nomDivision = DGV_Matchs.Columns[2];
            nomDivision.Width = 80;
            DataGridViewColumn ville = DGV_Matchs.Columns[3];
            ville.Width = 85;
        }
        private void Modifier()
        {
            Form_Ajouter_Match Modifier = new Form_Ajouter_Match(oracon, connection);
            Modifier.Text = "Modification";
            Modifier.numeroMatch = DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.equipeHome = DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.equipeVisiteur = DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString();
            Modifier.dateRencontre = DGV_Matchs.SelectedRows[0].Cells[3].Value.ToString();
            Modifier.lieuRencontre = DGV_Matchs.SelectedRows[0].Cells[4].Value.ToString();
            //Modifier.scoreHome = DGV_Matchs.SelectedRows[0].Cells[5].Value.ToString();
            //Modifier.scoreVisiteur = DGV_Matchs.SelectedRows[0].Cells[6].Value.ToString();

            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlModif = "Update Match set EquipeReceveur =:EquipeHome, EquipeVisiteur =:EquipeVisiteur, DateRecontre =:DateRencontre, " +
                    "LieuRencontre =:Lieu where NumeroMatch =:NumeroMatch";

                try
                {
                    OracleCommand oraMatchModif = new OracleCommand(sqlModif, oracon);


                    OracleParameter OraParaEquipeHome = new OracleParameter(":EquipeHome", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaEquipeVisiteur = new OracleParameter(":EquipeVisiteur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaDateRencontre = new OracleParameter(":DateRencontre", OracleDbType.Date);
                    OracleParameter OraParaLieu = new OracleParameter(":Lieu", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaScoreHome = new OracleParameter(":ScoreHome", OracleDbType.Int32);
                    OracleParameter OraParaScoreVisiteur = new OracleParameter(":ScoreVisiteur", OracleDbType.Int32);
                    OracleParameter OraParaNumMatch = new OracleParameter(":NumeroMatch", OracleDbType.Int32);

                    OraParaEquipeHome.Value = Modifier.equipeHome;
                    OraParaEquipeVisiteur.Value = Modifier.equipeVisiteur;
                    OraParaDateRencontre.Value = DateTime.Parse(Modifier.dateRencontre);
                    OraParaLieu.Value = Modifier.lieuRencontre;
                    OraParaNumMatch.Value = Modifier.numeroMatch;
                    //OraParaScoreHome.Value = int.Parse(Modifier.scoreHome);
                    //OraParaScoreVisiteur.Value = int.Parse(Modifier.scoreVisiteur);

                    oraMatchModif.Parameters.Add(OraParaEquipeHome);
                    oraMatchModif.Parameters.Add(OraParaEquipeVisiteur);
                    oraMatchModif.Parameters.Add(OraParaDateRencontre);
                    oraMatchModif.Parameters.Add(OraParaLieu);
                    //oraMatchModif.Parameters.Add(OraParaScoreHome);
                    //oraMatchModif.Parameters.Add(OraParaScoreVisiteur);
                    oraMatchModif.Parameters.Add(OraParaNumMatch);

                    oraMatchModif.ExecuteNonQuery();

                    LoadDGVmatch();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void BTN_ModifierMatch_Click(object sender, EventArgs e)
        {
            Modifier();
        }
        private void Form_Matchs_Load(object sender, EventArgs e)
        {
            BTN_AjoutRencontre.Select();
            LoadSettings();
            LoadDGVmatch();
        }
        private void DGV_Matchs_SelectionChanged(object sender, EventArgs e)
        {
            PB_EquipeHome.Image = null;
            PB_EquipeAway.Image = null;


            if (DGV_Matchs.SelectedRows.Count > 0)
            {
                OracleCommand oraImage = oracon.CreateCommand();
                oraImage.CommandText = "SELECT (SELECT Logo FROM Equipe WHERE NomEquipe=:NomEquipe1), (SELECT Logo FROM Equipe WHERE NomEquipe=:NomEquipe2) FROM DUAL";
                oraImage.Parameters.Add(new OracleParameter(":NomEquipe1", DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString()));
                oraImage.Parameters.Add(new OracleParameter(":NomEquipe2", DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString()));

                FillStats();

                LB_NbButsHome.Text = DGV_Matchs.SelectedRows[0].Cells[5].Value.ToString();
                LB_NbButsAway.Text = DGV_Matchs.SelectedRows[0].Cells[6].Value.ToString();
                TB_Receveur.Text = DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString();
                TB_Visiteur.Text = DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString();
                using (OracleDataReader oraReader = oraImage.ExecuteReader())
                {
                    if (oraReader.Read())
                    {
                        OracleBlob oraBlob = oraReader.GetOracleBlob(0);
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
                                PB_EquipeHome.Image = Image.FromStream(ms);
                            }
                        }

                        oraBlob = oraReader.GetOracleBlob(1);
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
                                PB_EquipeAway.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
        }
        private void Form_Matchs_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
            if (callBackForm != null)
                callBackForm.Show();
        }
        private void Calendrier()
        {
            Form_Calendrier_Matchs cal = new Form_Calendrier_Matchs(oracon, connection);
            this.Hide();
            cal.callBackForm = this;
            cal.ShowDialog();
        }
        private void BTN_Calendrier_Click(object sender, EventArgs e)
        {
            Calendrier();
        }

        private void FillStats()
        {
            //Form_Statistiques Stats = new Form_Statistiques(oracon, connection, DGV_Joueurs.SelectedRows[0].Cells[0].Value.ToString());
            //this.Hide();
            //Stats.callBackForm = this;
            DGV_Joueurs.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Joueurs.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Joueurs.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            OracleCommand oraJoueurs = oracon.CreateCommand();
            oraJoueurs.CommandText = "SELECT NUMEROJOUEUR, NUMEROMAILLOT, NOMJOUEUR, POSITIONJOUEUR, NOMEQUIPE, NOMBREBUTS, NOMBREPASSES, NOMBREPOINTS FROM JOUEURRECEVEUR " +
                                     "WHERE EQUIPERECEVEUR='" + DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString() + "' and NumeroMatch = " + DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString() + " UNION " +
                                     "SELECT NUMEROJOUEUR, NUMEROMAILLOT, NOMJOUEUR, POSITIONJOUEUR, NOMEQUIPE, NOMBREBUTS, NOMBREPASSES, NOMBREPOINTS FROM JOUEURVISITEUR " +
                                     "WHERE EQUIPEVISITEUR='" + DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString() + "' and NumeroMatch = " + DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString() +
                                     " ORDER BY 7 DESC";

            OracleDataAdapter oraDataJoueurs = new OracleDataAdapter(oraJoueurs);
            joueursDataSet = new DataSet();
            oraDataJoueurs.Fill(joueursDataSet, "JoueursDGV");
            DGV_Joueurs.DataSource = joueursDataSet.Tables[0];
            //MessageBox.Show(DGV_Joueurs.SelectedRows[0].Cells[0].Value.ToString());
            //Stats.numeroJoueurs = DGV_Joueurs.SelectedRows[0].Cells[0].Value.ToString();
            //Stats.ShowDialog();
        }

        private void BTN_AjoutStats_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Stats AjoutStats = new Form_Ajouter_Stats(oracon, connection);
            this.Hide();
            AjoutStats.callBackForm = this;
            AjoutStats.numMatch = DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString();
            AjoutStats.equipeHome = DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString();
            AjoutStats.equipeVisiteur = DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString();

            if (AjoutStats.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlAjoutStats = "insert into FicheJoueur(NumeroMatch,NumeroJoueur,NombreButs,NombrePasses,TempsPunition)" +
                    " VALUES(:NumeroMatch,:NumeroJoueurs,:NBBUTS,:NBPASSES,:TEMPSPUNITION)";
                try
                {
                    OracleCommand oraAjoutStats = new OracleCommand(sqlAjoutStats, oracon);

                    OracleParameter OraParaNumJoueurs = new OracleParameter(":NumeroJoueurs", OracleDbType.Int32);
                    OracleParameter OraParaNumMatch = new OracleParameter(":NumeroMatch", OracleDbType.Int32);
                    OracleParameter OraParaNBButs = new OracleParameter(":NBBUTS", OracleDbType.Int32);
                    OracleParameter OraParaNbPasses = new OracleParameter(":NBPASSES", OracleDbType.Int32);
                    OracleParameter OraParaTempsPunition = new OracleParameter(":TEMPSPUNITION", OracleDbType.Int32);

                    OraParaNumJoueurs.Value = AjoutStats.numJoueur;
                    OraParaNumMatch.Value = AjoutStats.numMatch;
                    OraParaNBButs.Value = AjoutStats.nbButs;
                    OraParaNbPasses.Value = AjoutStats.nbPasses;
                    OraParaTempsPunition.Value = AjoutStats.tempsPunition;

                    oraAjoutStats.Parameters.Add(OraParaNumJoueurs);
                    oraAjoutStats.Parameters.Add(OraParaNumMatch);
                    oraAjoutStats.Parameters.Add(OraParaNBButs);
                    oraAjoutStats.Parameters.Add(OraParaNbPasses);
                    oraAjoutStats.Parameters.Add(OraParaTempsPunition);


                    oraAjoutStats.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 1)
                    {
                        MessageBox.Show("Vous ne pouvez pas rajouter des stats de joueurs qui ont deja eu des stats pour le match en visionnement", "Erreur 00001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }
        private void AjouterStats()
        {
            // PROBLÈME ICI
            Form_Statistiques stats = new Form_Statistiques(oracon, connection, DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString());
            this.Hide();
            stats.Text = "Statistiques";
            stats.callBackForm = this;
            stats.numeroJoueurs = DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString();
            stats.ShowDialog();
        }
        private void DGV_Joueurs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AjouterStats();
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

        private void ajouterMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_AjoutRencontre_Click(sender, e);
        }

        private void modifierMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_ModifierMatch_Click(sender, e);
        }

        private void ajouterStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterStats();
        }

        private void calendrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Calendrier_Click(sender, e);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            if (keyData == (Keys.Control | Keys.Shift | Keys.C))
                Calendrier();
            if (keyData == (Keys.Control | Keys.Shift | Keys.S))
                AjouterStats();
            if (keyData == Keys.F1)
                MessageBox.Show("Voici les touches ayant un racourci \n" +
                                "F1- Aide \n" +
                                "Ctrl+Q- Quitter \n" +
                                "Ctrl+A - Ajouter un match \n" +
                                "Ctrl+M - Modifier le match sélectionné\n" +
                                "Ctrl+Shift+S - Page statistique\n" +
                                "Ctrl+Shift+C - Page calendrier\n", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterStats();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void calendrierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calendrier();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_APropos propos = new Form_APropos();
            propos.Text = "À Propos";
            this.Hide();
            propos.callBackForm = this;
            propos.ShowDialog();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Preferences preferences = new Form_Preferences(true, Properties.Settings.Default.Form_Matchs_Police, Properties.Settings.Default.Form_Matchs_CouleurPolice, Properties.Settings.Default.Form_Matchs_CouleurForm, Properties.Settings.Default.Form_Matchs_DGVPolice, Properties.Settings.Default.Form_Matchs_DGVCouleurPolice);
            this.Enabled = false;
            preferences.ShowDialog();
            this.Enabled = true;
            modificationPreferences();
        }
        private void modificationPreferences()
        {
            SaveSettings();
            Properties.Settings.Default.Form_Matchs_CouleurForm = Properties.Settings.Default.Preferences_CouleurForm;
            Properties.Settings.Default.Form_Matchs_Police = Properties.Settings.Default.Preferences_Police;
            Properties.Settings.Default.Form_Matchs_CouleurPolice = Properties.Settings.Default.Preferences_CouleurPolice;
            Properties.Settings.Default.Form_Matchs_DGVPolice = Properties.Settings.Default.Preferences_DGVPolice;
            Properties.Settings.Default.Form_Matchs_DGVCouleurPolice = Properties.Settings.Default.Preferences_DGVCouleurPolice;
            LoadSettings();
        }

        private void BTN_AjoutStats_Click_1(object sender, EventArgs e)
        {
            AjouterStats();
        }
    }
}
