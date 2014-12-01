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
        private bool Currval = false;
        public Form_Matchs(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }

        private void BTN_AjoutRencontre_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Match ajm = new Form_Ajouter_Match();
            ajm.Text = "Ajout de match";
            callBackForm = this;
            this.Hide();
            ajm.ShowDialog();
        }

        private void LoadDGVstats()
        {
            DGV_Joueurs.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Joueurs.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Joueurs.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            int lastIndex = -1;
            if (DGV_Joueurs.SelectedRows.Count > 0) lastIndex = DGV_Joueurs.SelectedRows[0].Index;

            OracleCommand oraSelect = oracon.CreateCommand();
            //oraSelect.CommandText = "SELECT NumeroMatch, nomjoueur, nombrebuts, nombrepasses, tempspunition FROM FicheJoueur" +
            //                        "inner join joueur on FicheJoueur.numerojoueur = joueur.numerojoueur";
            oraSelect.CommandText = "SELECT * from FicheJoueur";
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            joueursDataSet = new DataSet();
            oraAdapter.Fill(joueursDataSet, "StatsJoueurs");
            DGV_Joueurs.DataSource = joueursDataSet.Tables[0];

            if (lastIndex > -1 && DGV_Joueurs.Rows.Count > 0) DGV_Joueurs.Rows[Math.Min(lastIndex, DGV_Joueurs.Rows.Count - 1)].Selected = true;
        }

        private void LoadDGVmatch()
        {
            DGV_Matchs.AllowUserToResizeColumns = false; // Empêche le resize des colonnes
            DGV_Matchs.AllowUserToResizeRows = false; // Empêche le resize des rangées
            DGV_Matchs.AllowUserToAddRows = false; // Enlève la ligne vide à la fin du DGV
            int lastIndex = -1;
            if (DGV_Matchs.SelectedRows.Count > 0) lastIndex = DGV_Matchs.SelectedRows[0].Index;

            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT * FROM Match";
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

        private void BTN_ModifierMatch_Click(object sender, EventArgs e)
        {

        }

        private void Form_Matchs_Load(object sender, EventArgs e)
        {
            LoadDGVmatch();
            LoadDGVstats();
            TB_EquipeHome.Select();
        }

        private void DGV_Matchs_SelectionChanged(object sender, EventArgs e)
        {
            //PB_EquipeHome.Image = null;
            //PB_EquipeAway.Image = null;


            //if (DGV_Matchs.SelectedRows.Count > 0)
            //{
            //    OracleCommand oraImage = oracon.CreateCommand();
            //    oraImage.CommandText = "SELECT (SELECT Logo FROM Equipe WHERE NomEquipe=:NomEquipe1), (SELECT FROM Equipe WHERE NomEquipe=:NomEquipe2) FROM DUAL";
            //    oraImage.Parameters.Add(new OracleParameter(":NomEquipe1", DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString()));
            //    oraImage.Parameters.Add(new OracleParameter(":NomEquipe2", DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString()));

            //    OracleCommand oraJoueurs = oracon.CreateCommand();
            //    oraJoueurs.CommandText = " SELECT * FROM JOUEUR INNER JOIN MATCH ON JOUEUR.nomequipe = MATCH.EQUIPEreceveur " +
            //                             " WHERE EQUIPEReceveur='" + DGV_Matchs.SelectedRows[0].Cells[1].Value.ToString() + "' and Match.NumeroMatch = " + DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString() + "  UNION " +
            //                             " SELECT * FROM JOUEUR INNER JOIN MATCH ON JOUEUR.nomequipe = MATCH.EQUIPEVISITEUR" +
            //                             "  WHERE EQUIPEVISITEUR= '" + DGV_Matchs.SelectedRows[0].Cells[2].Value.ToString() + "' and Match.NumeroMatch = " + DGV_Matchs.SelectedRows[0].Cells[0].Value.ToString() + " ORDER BY 6 ";
            //    OracleDataAdapter oraDataJoueurs = new OracleDataAdapter(oraJoueurs);
            //    matchDataSet = new DataSet();
            //    oraDataJoueurs.Fill(matchDataSet, "JoueursDGV");
            //    DGV_Joueurs.DataSource = matchDataSet.Tables[0];


            //    TB_EquipeHome.Text = DGV_Matchs.SelectedRows[0].Cells[5].Value.ToString();
            //    TB_EquipeAway.Text = DGV_Matchs.SelectedRows[0].Cells[6].Value.ToString();
            //    using (OracleDataReader oraReader = oraImage.ExecuteReader())
            //    {
            //        if (oraReader.Read())
            //        {
            //            OracleBlob oraBlob = oraReader.GetOracleBlob(0);
            //            if (!oraBlob.IsNull)
            //            {
            //                using (MemoryStream ms = new MemoryStream())
            //                {
            //                    byte[] buffer = new byte[8 * 1024];
            //                    int read = 0;
            //                    while ((read = oraBlob.Read(buffer, 0, 8 * 1024)) > 0)
            //                    {
            //                        ms.Write(buffer, 0, read);
            //                    }
            //                    PB_EquipeHome.Image = Image.FromStream(ms);
            //                }
            //            }

            //            oraBlob = oraReader.GetOracleBlob(1);
            //            if (!oraBlob.IsNull)
            //            {
            //                using (MemoryStream ms = new MemoryStream())
            //                {
            //                    byte[] buffer = new byte[8 * 1024];
            //                    int read = 0;
            //                    while ((read = oraBlob.Read(buffer, 0, 8 * 1024)) > 0)
            //                    {
            //                        ms.Write(buffer, 0, read);
            //                    }
            //                    PB_EquipeAway.Image = Image.FromStream(ms);
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
