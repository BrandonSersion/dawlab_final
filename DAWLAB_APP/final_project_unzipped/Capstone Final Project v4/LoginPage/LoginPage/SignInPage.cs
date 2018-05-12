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
    public partial class SignInPage : Form
    {
        string connectionString = @"Server=localhost;Database=signupdb;Uid=root;Pwd= ";
        int UserID = 0;
        public SignInPage()
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

            var regex = new Regex(
                @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b", RegexOptions.IgnoreCase);

            var matchValue = regex.Match(txtEmail.Text);
            
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Please fill mandatory fields");
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                txtPassword.Text = txtConfirmPassword.Text = "";
            }
            else if (dtblBook.Rows.Count == 1)
            {
                MessageBox.Show("An account has already been made for this user");
            }
            else if (matchValue.Success != true)
            {
                MessageBox.Show("Invalid Email");
                txtEmail.Text = "";
            }
            

            else
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("SignUpAdd", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_UserID", UserID);
                    mySqlCmd.Parameters.AddWithValue("_Username", txtUsername.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Password", txtPassword.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Email", txtEmail.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted Successfully");
                    Clear();
                    this.Hide();
                }
            }

            void Clear()
            {
                txtUsername.Text = txtPassword.Text = txtConfirmPassword.Text = txtEmail.Text =  "";
                
                UserID = 0;
                btnSubmit.Text = "Sign Up!";
            }
        }


        private void SignInPage_Load(object sender, EventArgs e)
        {

        }



    }
}