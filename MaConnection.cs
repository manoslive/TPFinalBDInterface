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
                if(connection.State == ConnectionState.Open)
                {
                    if (MessageBox.Show("Vous êtes maintenant connecté!" + "\n" + "Bienvenue dans un monde rempli d'intrigues!", "État de connection à la BD") == DialogResult.OK)
                    {
                        resultat = true;
                    }
                }
                else
                {
                    MessageBox.Show("ERREUUUUR","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    resultat = false;
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
