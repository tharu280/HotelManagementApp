using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "nsbm" && txtpass.Text == "1111")
            {
                new Form2().Show();
                this.Hide();
            }
            else { MessageBox.Show("The Password or Username you entered is incorrect,Please try again");
                txtname.ResetText();
                txtpass.ResetText();
                txtname.Focus();
            }
        }

        private void labclear_Click(object sender, EventArgs e)
        {
            txtname.ResetText();
            txtpass.ResetText();
            txtname.Focus();//clearing and focusing the curser to the name
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
