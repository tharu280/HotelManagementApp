﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginpage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Checkin().Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            new Checkout().Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            new Clientupdate().Show();
            this.Hide();
        }
    }
}
