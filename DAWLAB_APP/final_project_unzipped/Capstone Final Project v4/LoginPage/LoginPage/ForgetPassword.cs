using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace LoginPage
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=signupdb;Uid=root;Pwd= ";
            MySqlConnection mysqlConn = new MySqlConnection(connectionString);
            string query = "Select * from signup Where Email = '" + txtEmail.Text.Trim() + "'";
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, mysqlConn);
            DataTable dtblBook = new DataTable();
            sqlDa.Fill(dtblBook);

            if (txtEmail.Text == "")
                MessageBox.Show("Please enter email");

            else if (dtblBook.Rows.Count == 1)
            {
                MessageBox.Show("Email has been sent!");
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Email");
            }
        }
    }
}
