﻿using System;
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
            WinPercentageTrackerFrm Q1 = new WinPercentageTrackerFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            WinPercentageTrackerFrm Q1 = new WinPercentageTrackerFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            this.uxLoader.Controls.Clear();
            RankTeamAvgKillsFrm Q2 = new RankTeamAvgKillsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            RankTeamHighestWinFrm Q3 = new RankTeamHighestWinFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            RankPlayerByKillsFrm Q4 = new RankPlayerByKillsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q4.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q4);
            Q4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            TournamentWinnerFrm Q4 = new TournamentWinnerFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q4.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q4);
            Q4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            UpdatePlayerEmailFrm Q4 = new UpdatePlayerEmailFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q4.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q4);
            Q4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            AddNewPlayerFrm Q4 = new AddNewPlayerFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q4.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q4);
            Q4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            AddTeamFrm Q4 = new AddTeamFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q4.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q4);
            Q4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(46, 51, 73);
            uxQ1.BackColor = Color.FromArgb(24, 30, 54);
            uxQ2.BackColor = Color.FromArgb(24, 30, 54);
            uxQ3.BackColor = Color.FromArgb(24, 30, 54);
            uxQ4.BackColor = Color.FromArgb(24, 30, 54);
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button4.BackColor = Color.FromArgb(24, 30, 54);
            this.uxLoader.Controls.Clear();
            UpdateTournamentWinner Q4 = new UpdateTournamentWinner() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Q4.FormBorderStyle = FormBorderStyle.None;
            this.uxLoader.Controls.Add(Q4);
            Q4.Show();
        }
    }
}
