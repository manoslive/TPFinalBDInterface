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
    public partial class Form_Preferences : Form
    {
        public Form_Preferences(bool DGV,System.Drawing.Font Police, System.Drawing.Color CouleurPolice, System.Drawing.Color CouleurForm,
                                System.Drawing.Font DGVPolice, System.Drawing.Color DGVCouleurPolice) 
        {
            InitializeComponent();
            LoadSettings(Police, CouleurPolice, CouleurForm, DGVPolice, DGVCouleurPolice);
            if(!DGV)
            {
                this.Size = new System.Drawing.Size(354, 162);
            }
        }
        public void LoadSettings(System.Drawing.Font Police, System.Drawing.Color CouleurPolice, System.Drawing.Color CouleurForm,
                                System.Drawing.Font DGVPolice, System.Drawing.Color DGVCouleurPolice)
        {
            Properties.Settings.Default.Preferences_Police = Police;
            Properties.Settings.Default.Preferences_CouleurPolice = CouleurPolice;
            Properties.Settings.Default.Preferences_CouleurForm = CouleurForm;
            Properties.Settings.Default.Preferences_DGVPolice = DGVPolice;
            Properties.Settings.Default.Preferences_DGVCouleurPolice = DGVCouleurPolice;
            LoadCouleurs();
        }
        public void LoadCouleurs()
        {
            PN_CouleurPolice.BackColor = Properties.Settings.Default.Preferences_CouleurPolice;
            PN_CouleurForm.BackColor = Properties.Settings.Default.Preferences_CouleurForm;
            PN_DGVCouleurPolice.BackColor = Properties.Settings.Default.Preferences_DGVCouleurPolice;
        }
        private void FB_PoliceForm_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FontDialog monFont = new FontDialog();
            monFont.MaxSize = 18;
            monFont.Font = Properties.Settings.Default.Preferences_Police;
            if (monFont.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Preferences_Police = monFont.Font;
            }
            this.Enabled = true;
        }

        private void FB_CouleurPoliceForm_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Preferences_CouleurPolice = colorPicker.Color;
                PN_CouleurPolice.BackColor = colorPicker.Color;
            }
            this.Enabled = true;
        }

        private void FB_CouleurForm_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Preferences_CouleurForm = colorPicker.Color;
                PN_CouleurForm.BackColor = colorPicker.Color;
            }
            this.Enabled = true;
        }

        private void FB_DGVPolice_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FontDialog monFont = new FontDialog();
            monFont.MaxSize = 14;
            monFont.Font = Properties.Settings.Default.Preferences_DGVPolice;
            if (monFont.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Preferences_DGVPolice = monFont.Font;
            }
            this.Enabled = true;
        }

        private void FB_DGVCouleurPolice_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Preferences_DGVCouleurPolice = colorPicker.Color;
                PN_DGVCouleurPolice.BackColor = colorPicker.Color;
            }
            this.Enabled = true;
        }
    }
}
