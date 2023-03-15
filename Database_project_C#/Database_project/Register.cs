using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_project
{
    public partial class Register : Form
    {
        static string conn = ConfigurationManager.ConnectionStrings["justDatabase"].ConnectionString;
        SqlConnection sqlConnection = DatabaseSingleton.GetInstance();
        public Register()
        {
            InitializeComponent();
        }
        //checking if user input is correct according to the regexes
        private void RegisterButton_Click(object sender, EventArgs e)
        {

            string usernameRegex = "^[a-zA-Z0-9]{4,20}$";
            string passwordRegex = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d]{8,}$";
            string userNameInput = textBox1.Text;
            string passwordInput = textBox2.Text;

            if (Regex.IsMatch(userNameInput, usernameRegex) && Regex.IsMatch(passwordInput, passwordRegex))
            {
                string query = "Insert into Users (UserName, UserPassword) values('" + userNameInput + "','" + passwordInput + "')";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();

                Login_Form loginForm = new Login_Form();
                loginForm.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("You have not met the requirements for registration");
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
