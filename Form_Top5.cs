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
    public partial class Form_Top5 : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        private DataSet dataSetTop3 = new DataSet();
        public Form_Top5(OracleConnection connectionoracle, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connectionoracle;
            connection = maBelleConnection;
        }

        private void Form_Top5_Load(object sender, EventArgs e)
        {
            RemplirTop3Labels();
            RemplirTop3Photos();
        }

        private void RemplirTop3Labels()
        {
            string sqlNomJoueur = "SELECT NomJoueur, Photo FROM StatsJoueur where ROWNUM <=3";
            OracleCommand oraSelect = oracon.CreateCommand();
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            oraSelect.CommandText = sqlNomJoueur;
            oraAdapter.Fill(dataSetTop3, "tableFormTop3");
            DGV_Top3.DataSource = dataSetTop3.Tables[0];

            LB_Top1.Text = DGV_Top3.Rows[0].Cells[0].Value.ToString();
            LB_Top2.Text = DGV_Top3.Rows[1].Cells[0].Value.ToString();
            LB_Top3.Text = DGV_Top3.Rows[2].Cells[0].Value.ToString();
        }

        private void RemplirTop3Photos()
        {
            PB_Top1.ImageLocation = DGV_Top3.Rows[0].Cells[1].Value.ToString();
            PB_Top2.ImageLocation = DGV_Top3.Rows[1].Cells[1].Value.ToString();
            PB_Top3.ImageLocation = DGV_Top3.Rows[2].Cells[1].Value.ToString();

            PB_Top1.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Top2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Top3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
