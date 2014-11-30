using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TPFinal
{
    public partial class Form_Joueurs : Form
    {
        private OracleConnection oracon;
        private MaConnection cConnection;
        public Form_Joueurs(OracleConnection connectionoracle, MaConnection maBelleConnection)
        {
            InitializeComponent();
            oracon = connectionoracle;
            cConnection = maBelleConnection;
        }
    }
}
