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
    public partial class Form_Statistiques : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        private DataSet statsDataSet = null;
        public Form callBackForm = null;
        public Form_Statistiques(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }

        public string numeroJoueurs
        {
            get
            {
                return TB_NumJoueur.Text;
            }
            set
            {
                TB_NumJoueur.Text = value;
            }
        }

        private void Form_Statistiques_Load(object sender, EventArgs e)
        {
            if (numeroJoueurs != null)
            {
                try
                {
                    OracleCommand oraStats = oracon.CreateCommand();
                    oraStats.CommandText = " Select * From FicheJoueur where NumeroJoueur = " + numeroJoueurs;
                    OracleDataAdapter oraAdapter = new OracleDataAdapter(oraStats);
                    statsDataSet = new DataSet();
                    oraAdapter.Fill(statsDataSet);
                    DGV_Stats.DataSource = statsDataSet.Tables[0];

                    TB_NumJoueur.Text = DGV_Stats.Rows[0].Cells[0].Value.ToString();
                    TB_Nom.Text = DGV_Stats.Rows[0].Cells[1].Value.ToString();
                    TB_Prenom.Text = DGV_Stats.Rows[0].Cells[2].Value.ToString();
                    TB_Equipe.Text = DGV_Stats.Rows[0].Cells[3].Value.ToString();
                    TB_NbButs.Text = DGV_Stats.Rows[0].Cells[4].Value.ToString();
                    TB_NbPasses.Text = DGV_Stats.Rows[0].Cells[5].Value.ToString();
                    TB_NbPoints.Text = DGV_Stats.Rows[0].Cells[6].Value.ToString();
                    TB_TempsPunition.Text = DGV_Stats.Rows[0].Cells[7].Value.ToString();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Form_Statistiques_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
    }
}
