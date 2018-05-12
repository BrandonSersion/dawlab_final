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
using MySql.Data.MySqlClient;
using WindowsFormsApp1;



namespace LoginPage
{
    public partial class LoginAuthentication : Form
    {
        public LoginAuthentication()
        {
            InitializeComponent();
            this.ActiveControl = pictureBox1;
        }
        
        private void lblNewAccount_Click(object sender, EventArgs e)
        {
            SignInPage lblNewAccount = new SignInPage();
            lblNewAccount.Show();

        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword lblForgetPassword = new ForgetPassword();
            lblForgetPassword.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNewAccount_MouseHover(object sender, EventArgs e)
        {
            lblNewAccount.ForeColor = Color.Red;
        }

        private void lblNewAccount_MouseLeave(object sender, EventArgs e)
        {
            lblNewAccount.ForeColor = Color.Black;
        }

        private void lblForgetPassword_MouseHover(object sender, EventArgs e)
        {
            lblForgetPassword.ForeColor = Color.Red;
        }

        private void lblForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgetPassword.ForeColor = Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=signupdb;Uid=root;Pwd= ";
            MySqlConnection mysqlCon = new MySqlConnection(connectionString);
            string query = "Select * from signup Where Email = '" + txtEmail.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, mysqlCon);
            DataTable dtblBook = new DataTable();
            sqlDa.Fill(dtblBook);
           
            
            
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter Email Address");

            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password");

            }
            else if (dtblBook.Rows.Count != 1)
            {
                MessageBox.Show("Check your username and password");
            }
            else if ((txtEmail.Text == "lintonioburke@yahoo.com" && txtPassword.Text == "lintonio") ||
                    (txtEmail.Text == "wudistaychehyahoo.com" && txtPassword.Text == "wudist") ||
                    (txtEmail.Text == "alimohamed@yahoo.com" && txtPassword.Text == "ali") ||
                    (txtEmail.Text == "deanoates@yahoo.com" && txtPassword.Text == "dean") ||
                    (txtEmail.Text == "brandonsersion@yahoo.com" && txtPassword.Text == "brandon") ||
                    (txtEmail.Text == "antoniodrakeford@yahoo.com" && txtPassword.Text == "antonio"))
            {
                MessageBox.Show("Welcome " + txtEmail.Text + "!");
                AdminPage btnLogin = new AdminPage();
                this.Hide();
                btnLogin.Show();
            }
            else if (dtblBook.Rows.Count == 1)
            {
                MessageBox.Show("Welcome " + txtEmail.Text + "!");
                Preferences btnLogin = new Preferences();
                this.Hide();
                btnLogin.Show();
            }
            
            else
                {
                
            }

        }
        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;

        }   
    }
    
}

    

