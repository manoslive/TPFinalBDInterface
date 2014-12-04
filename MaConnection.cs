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
    public class MaConnection
    {
        private string motDePasse;
        private string nomDutilisateur;

        private string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
"(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

        public bool Connect(string User, string Mdp, OracleConnection connection)
        {
            bool resultat = false;
            try
            {
                string chaineConnection = "Data Source = " + Dsource + ";User Id =" + User + "; Password= " + Mdp;
                connection.ConnectionString = chaineConnection;
                connection.Open();
                if (MessageBox.Show(connection.State.ToString()) == DialogResult.OK)
                {
                    resultat = true;
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return resultat;
        }
    }
}
