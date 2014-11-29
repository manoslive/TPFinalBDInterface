using System;
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
    public partial class Form_Equipes : Form
    {
        private OracleConnection oracon = new OracleConnection(); //connection initialiser ici
        private DataSet dataSetEquipe = new DataSet();
        MaConnection maBelleConnection = new MaConnection();

        public string division = null;
        public Form_Equipes()
        {
            InitializeComponent();
        }

        private void Form_Equipe_Load(object sender, EventArgs e)
        {
            // On appelle la form de connection
            Form_Connection connection = new Form_Connection(oracon, maBelleConnection);
            connection.ShowDialog();
            // On rempli le DGV
            LoadDGV();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Form_Ajouter_Equipe Ajouter = new Form_Ajouter_Equipe();
            Ajouter.conn = oracon;
            Ajouter.Text = "Ajout";
            Ajouter.divisionEquipe = division;
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlAjout = "insert into Equipes (NomEquipe,DateIntroLigue,LogoEquipe,DivisionEquipe,VilleEquipe)" + // Rajout de LogoEquipe dans la commande ...incomming crashs bitches !
                    " VALUES(:NomEquipe,:DateIntroLigue,:LogoEquipe,:DivisionEquipe,:VilleEquipe)";
                try
                {

                    OracleCommand oraAjout = new OracleCommand(sqlAjout, oracon);

                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateIntroLigue = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParamLogoEquipe = new OracleParameter(":LogoEquipe", OracleDbType.Blob);  //Ajout
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);

                    OraParaNomEquipe.Value = Ajouter.nomEquipe;
                    OraParamDateIntroLigue.Value = DateTime.Parse(Ajouter.dateIntroLigue);
                    OraParamLogoEquipe.Value = null;
                    OraParaDivEquipe.Value = Ajouter.divisionEquipe;
                    OraParaVilleEquipe.Value = Ajouter.villeEquipe;

                    // petit_wily
                    if (Ajouter.image != null)
                    {
                        OraParamLogoEquipe.Value = Ajouter.image;
                    }

                    oraAjout.Parameters.Add(OraParaNomEquipe);
                    oraAjout.Parameters.Add(OraParamDateIntroLigue);
                    oraAjout.Parameters.Add(OraParamLogoEquipe);
                    oraAjout.Parameters.Add(OraParaDivEquipe);
                    oraAjout.Parameters.Add(OraParaVilleEquipe);

                    oraAjout.ExecuteNonQuery();

                    ReloadDGV();
                }

                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }    
        }
    }
}
