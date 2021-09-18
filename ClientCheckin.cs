using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginpage
{
    public partial class ClientCheckin : Form
    {
        public ClientCheckin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string checkDate = dtpCheckIn.Text;
            string checkTime = dtpCheckInTime.Text;
            string Firstname = txtName.Text;
            string Lastname = txtName2.Text;
            string Address = Add.Text;
            string Country = Con.Text;
            string Phone = p.Text;
            string EmailAddress = emailA.Text;
            string AdultsCount = NoAdults.Text;
            string ChildrenCount = NoChild.Text;



            string roomPref = "";

            if (rdStandar.Checked)
            {
                roomPref = "Standard";
            }
            else if (rdDeluxe.Checked)
            {
                roomPref = "Deluxe";
            }
            else if (rdSuite.Checked)
            {
                roomPref = "Suite";
            }

            string insertQuery = "INSERT INTO tbl_checkin (name, date) VALUES ('" + name + "','" + checkDate + "','" + checkTime + "','" + roomPref + "')";
            SqlConnection conn =  new SqlConnection(); ;
            string connString = "";
            conn.ConnectionString = connString;
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void ClientCheckin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
