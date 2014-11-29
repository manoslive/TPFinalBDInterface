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
    public partial class Form_Ajouter_Equipe : Form
    {
        private OracleConnection oracon;
        private MaConnection cConnection;
        public Form_Ajouter_Equipe(OracleConnection connection, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connection;
            cConnection = maBelleConnection;
        }
    }
}
