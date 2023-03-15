using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Data.SqlClient;


namespace Database_project
{
    public partial class Login_Form : Form
    {

        static string conn = ConfigurationManager.ConnectionStrings["justDatabase"].ConnectionString;
        SqlConnection sqlConnection = DatabaseSingleton.GetInstance();


        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validator();
        }
        //method for checking if the user input is the same as one of records in database
        public void Validator()
        {
            string userNameInput = userNameTextBox.Text;
            string passwordInput = PasswordTextBox.Text;


            SqlCommand command;
            SqlCommand IDcommand;
            SqlDataReader reader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string query = "";
            string IDquery = "";
            string output = "";
            string IDoutput = "";
            int ID;

            query = "Select UserName, UserPassword from Users";
            IDquery = "Select UserID from Users where UserName = '" + userNameInput + "'";
            command = new SqlCommand(query, sqlConnection);
            IDcommand = new SqlCommand(IDquery, sqlConnection);


            //Reading from database 
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                output = output + reader.GetValue(0) + "-" + reader.GetValue(1) + " \n"; //the \n makes sure that the output is well formated


            }
            //formating the output of records from database
            string[] pairs = output.Split(' ');

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            //spliting the records from database 
            foreach (string pair in pairs)
            {
                string[] keyValue = pair.Split('-');
                if (keyValue.Length >= 2)
                {
                    keyValuePairs.Add(keyValue[0].Trim(), keyValue[1].Trim());

                }
            }
            //checking if user input is one of the valid records in database
            if (keyValuePairs.ContainsKey(userNameInput) && keyValuePairs.ContainsValue(passwordInput))
            {
                reader.Close();
                reader = IDcommand.ExecuteReader();
                reader.Read();
                IDoutput = IDoutput + reader.GetValue(0);
                reader.Close();

                int.TryParse(IDoutput, out ID);
                MyUser user2 = new MyUser(ID, userNameInput, passwordInput);
                MainPageForm mainPage = new MainPageForm(user2);
                mainPage.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("Wrong user name or password");
                reader.Close();

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public void IDsetter()
        {

        }
        //open register window
        private void reggisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Visible = false;
        }
    }
}