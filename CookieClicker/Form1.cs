﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        double cookies = 0;
        int cursors = 0;
        int grannies = 0;
        int farms = 0;
        int mines = 0;
        int factories = 0;
        public Form1()
        {
            InitializeComponent(); 
            //Timer MyTimer = new Timer();
            //MyTimer.Interval = (1000); // 45 mins
            //MyTimer.Tick += new EventHandler(timer1_Tick);
            //MyTimer.Start();
            checkCookies();
        }

        private void cookieBtn_Click(object sender, EventArgs e)
        {
            cookies++;
            checkCookies();
        }

        private void checkCookies()
        {
            cookieCntLbl.Text = cookies.ToString("F1"); 
            cursorCntLbl.Text = cursors.ToString();
            grannyCntLbl.Text = grannies.ToString();
            FarmCntLbl.Text = farms.ToString();
            MineCntLbl.Text = mines.ToString();
            FactoryCntLbl.Text = factories.ToString();
            cursorsBtn.Enabled = (cookies >= 15) ? true : false;
            grannyBtn.Enabled = (cookies >= 100) ? true : false;
            farmBtn.Enabled = (cookies >= 1100) ? true : false;
            MineBtn.Enabled = (cookies >= 12000) ? true : false;
            factoryBtn.Enabled = (cookies >= 130000) ? true : false;
        }

        private void cursorsBtn_Click(object sender, EventArgs e)
        {
            cursors++;
            cookies = cookies - 15;
            cursorCntLbl.Text = cursors.ToString();
            checkCookies();
        }

        private void grannyBtn_Click(object sender, EventArgs e)
        {
            grannies++;
            cookies = cookies - 100;
            grannyCntLbl.Text = grannies.ToString();
            checkCookies();
        }

        private void farmBtn_Click(object sender, EventArgs e)
        {
            farms++;
            cookies = cookies - 1100;
            FarmCntLbl.Text = farms.ToString();
            checkCookies();
        }

        private void MineBtn_Click(object sender, EventArgs e)
        {
            mines++;
            cookies = cookies - 12000;
            MineCntLbl.Text = mines.ToString();
            checkCookies();
        }

        private void factoryBtn_Click(object sender, EventArgs e)
        {
            factories++;
            cookies = cookies - 130000;
            FactoryCntLbl.Text = factories.ToString();
            checkCookies();
        }

        private void calculateCookies()
        {
            double cursorsPerSecond = cursors * 0.1;
            double granniesPerSecond = grannies * 1;
            double farmsPerSecond = farms * 8;
            double minesperSecond = mines * 47;
            double factoriesPerSecond = factories * 260;

            double cookiesPerSecond = cursorsPerSecond + granniesPerSecond + farmsPerSecond + minesperSecond + factoriesPerSecond;

            cookies = cookies + cookiesPerSecond;
            checkCookies();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            calculateCookies();
        }
    }
}
