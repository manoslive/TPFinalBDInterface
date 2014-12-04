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
    public partial class Form_Ajouter_division : Form
    {
        private OracleConnection oracon = null;
        private MaConnection connection = null;
        public Form callBackForm = null;
        public Form_Ajouter_division(OracleConnection connect, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connect;
            connection = maBelleConnection;
        }
        public string nomDivision
        {
            get
            {
                return TB_NomDivision.Text;
            }
            set
            {
                TB_NomDivision.Text = value;
            }
        }
        public string dateCreation
        {
            get
            {
                return DTP_DateCreation.Value.ToShortDateString();
            }
            set
            {
                DTP_DateCreation.Value = DateTime.Parse(value);
            }
        }
    }
}
