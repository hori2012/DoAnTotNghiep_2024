using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecommendationLocation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = new Guna2CheckBox();
            checkBox.Checked = false;
            checkBox.Text = "Click me";
            Guna2CheckBox checkBox1 = new Guna2CheckBox();
            checkBox1.Checked = false;
            checkBox1.Text = "Click me1";
            comHotels.Controls.Add(checkBox);
            comHotels.Controls.Add(checkBox1);
        }
    }
}
