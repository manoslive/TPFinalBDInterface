using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class Form_APropos : Form
    {
        public Form callBackForm = null;
        public Form_APropos()
        {
            InitializeComponent();
        }

        private void PB_Manu_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PB_Shaun_Click(object sender, EventArgs e)
        {

        }

        private void Form_APropos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_APropos_Load(object sender, EventArgs e)
        {
            BTN_Fermer.Select();
        }
    }
}
