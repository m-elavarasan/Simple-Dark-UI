using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Dark_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lightMode();
        }
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == true)
                darkMode();
            else
                lightMode();
        }

        private void darkMode()
        {
            panel2.BackColor =Color.FromArgb(44, 62, 80);
            lbltxt.Text = "Dark Mode";
            lbltxt.ForeColor = Color.White;
            materialSwitch1.Text = "";
        }
        private void lightMode()
        {
            panel2.BackColor = Color.White;
            lbltxt.Text = "Light Mode";
            lbltxt.ForeColor = Color.Black;
            materialSwitch1.Text = "Dark Mode";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
