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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Addcontrol();


        }

        public void Addcontrol()
        {
            Guna2GroupBox groupPlay = new Guna2GroupBox();
            groupPlay.BackColor = Color.White;
            groupPlay.Size = new System.Drawing.Size(1405, 330);
            groupPlay.Location = new System.Drawing.Point(35, 960);
            groupPlay.Text = "Vui chơi/Tham quan";
            groupPlay.BorderRadius = 5;
            groupPlay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.Controls.Add(groupPlay);
            FlowLayoutPanel flowPlay = new FlowLayoutPanel();
            flowPlay.Dock = DockStyle.Fill;
            groupPlay.Controls.Add(flowPlay);

            Guna2GroupBox groupCoffee = new Guna2GroupBox();
            groupCoffee.BackColor = Color.White;
            groupCoffee.Size = new System.Drawing.Size(1405, 330);
            groupCoffee.Location = new System.Drawing.Point(35, 1310);
            groupCoffee.Text = "Cà phê";
            groupCoffee.BorderRadius = 5;
            groupCoffee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.Controls.Add(groupCoffee);
            FlowLayoutPanel flowCoffee = new FlowLayoutPanel();
            flowCoffee.Dock = DockStyle.Fill;
            groupPlay.Controls.Add(flowCoffee);

        }
    }
}
