using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loginpage
{
    public partial class Delete : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.parse(taxID.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalID)\MSSQLLocalDB");
            string DelQry = "DELETE FROM Infotable WHERE ID_Number ="+id+"";
            SqlCommand cmd = new SqlCommand(DelQry,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessgeBox.show("Data Delete Successfuly");
            }
            catch(SqlException se)
            {
                MessgeBox.show("Error occured" + se.Tostring());
            }
            finaly
            {
               con.close();
            }
        }
    }