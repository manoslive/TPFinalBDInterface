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
using System.Runtime.InteropServices;
using System.Media;
using System.Timers;

namespace TPFinal
{
    public partial class Form_Connection : Form
    {
        private OracleConnection oracon;
        private MaConnection maBelleConnection;
        private static System.Timers.Timer monTimer;
        public Form_Connection(OracleConnection connection, MaConnection maBelleConnection) //recoit la connection en parametre
        {
            InitializeComponent();
            SetOracleConnection(connection); //set la connection dans l'attribut
            SetMaConnection(maBelleConnection);
        }
        // DLLs et constantes pour le movement de la Form_Main
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // Fin de DLLs et constantes pour le movement de la Form_Main
        public void SetMaConnection(MaConnection laConnection)
        {
            maBelleConnection = laConnection;
        }
        public void SetOracleConnection(OracleConnection connection)
        {
            oracon = connection;
        }
        private OracleConnection GetOracleConnection()
        {
            return oracon;
        }
        private void BTN_Connection_Click(object sender, EventArgs e)
        {
            string user = TB_Username.Text;
            string password = TB_Password.Text;
            try
            {
                //MaConnection maBelleConnection = new MaConnection(); // replacé dans la form1 pour etre envoyer ici
                if (maBelleConnection.Connect(user, password, GetOracleConnection())) //envoi les info à la classe pour effectuer la connection
                {
                    this.DialogResult = DialogResult.OK;
                    monTimer = new System.Timers.Timer(2000);
                    SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.MontrealGoalHorn);
                    monTimer.AutoReset = false;
                    monTimer.Start();
                    simpleSound.Play();
                    while(monTimer.Enabled)
                    {}
                    simpleSound.Stop();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void Form_Connection_Load(object sender, EventArgs e)
        {
            FB_Connection.Select();
            TB_Username_TextChanged(sender, e);
        }

        private void BTN_Connect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTN_Connection_Click(sender, e);
        }

        private void Form_Connection_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TB_Username_TextChanged(object sender, EventArgs e)
        {
            if (TB_Password.Text == "" || TB_Username.Text == "")
                FB_Connection.Enabled = false;
            else
                FB_Connection.Enabled = true;
        }

        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            oracon.Close();
            this.Close();
        }
    }
}
