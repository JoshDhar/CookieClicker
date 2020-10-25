using System;
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
        int cookies = 0;
        int cursors = 0;
        int grannies = 0;
        int farms = 0;
        int mines = 0;
        int factories = 0;
        public Form1()
        {
            InitializeComponent();
            checkCookies();
        }

        private void cookieBtn_Click(object sender, EventArgs e)
        {
            cookies++;
            cookieCntLbl.Text = cookies.ToString();
            checkCookies();
        }

        private void checkCookies()
        {
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
            grannyCntLbl.Text = cursors.ToString();
            checkCookies();
        }

        private void farmBtn_Click(object sender, EventArgs e)
        {
            farms++;
            cookies = cookies - 1100;
            FarmCntLbl.Text = cursors.ToString();
            checkCookies();
        }

        private void MineBtn_Click(object sender, EventArgs e)
        {
            mines++;
            cookies = cookies - 12000;
            MineCntLbl.Text = cursors.ToString();
            checkCookies();
        }

        private void factoryBtn_Click(object sender, EventArgs e)
        {
            factories++;
            cookies = cookies - 130000;
            FactoryCntLbl.Text = cursors.ToString();
            checkCookies();
        }
    }
}
