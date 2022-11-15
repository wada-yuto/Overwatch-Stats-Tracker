using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ApexDatabaseApplication
{
    public partial class uxMainWindow : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //);

        public uxMainWindow()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.uxLoader.Controls.Clear();
            Query1 Q1 = new Query1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q1.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q1);
            Q1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void uxQ1_Click(object sender, EventArgs e)
        {
            uxQ1.BackColor = Color.FromArgb(46, 51, 73);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            Query1 Q1 = new Query1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q1.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q1);
            Q1.Show();

        }

        private void uxQ2_Click(object sender, EventArgs e)
        {
            uxQ2.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            this.uxLoader.Controls.Clear();
            Query2 Q2 = new Query2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q2.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q2);
            Q2.Show();

        }

        private void uxQ3_Click(object sender, EventArgs e)
        {
            uxQ3.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            Query3 Q3 = new Query3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q3.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q3);
            Q3.Show();
        }

        private void uxQ4_Click(object sender, EventArgs e)
        {
            uxQ4.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            Query4 Q4 = new Query4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q4.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q4);
            Q4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
