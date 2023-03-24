using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Database_project
{
    public partial class MainPageForm : Form
    {

        private MyUser user;
        //getting the user from login form
         public MainPageForm(MyUser user)
           {
               InitializeComponent();
               this.user = user;
              
           }
        static string conn = ConfigurationManager.ConnectionStrings["justDatabase"].ConnectionString;
        SqlConnection sqlConnection = DatabaseSingleton.GetInstance();



        public MainPageForm()
        {
            InitializeComponent();
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadUsers_Click(object sender, EventArgs e)
        {
            idkwhatIamDoin();

        }
        //sending message
        private void MessageButton_Click(object sender, EventArgs e)
        {


            Dictionary<string, int> userDict = new Dictionary<string, int>();
            string subject = SubjectTextBox.Text;
            string message = MessageTextBox.Text;
            
            string query = "SELECT UserId, UserName FROM Users";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            // Add UserId and UserName pairs to dictionary
            while (reader.Read())
            {
                //adding user into dictionary
                int userId = (int)reader["UserId"];
                string userName = (string)reader["UserName"];
                userDict.Add(userName, userId);
            }

            //sending messsage to the selected users
            foreach (string checkedItem in listOfUsers.CheckedItems)
            {
                if (userDict.ContainsKey(checkedItem))
                {
                    int matchingUserId = userDict[checkedItem];
                    reader.Close();
                    string messageQuery4 = "Insert into dbo.Messages (SenderId, Subject, Body, CreatedAt, receiverId) values (" + user.ID + ", '" + subject + "', '" + message + "', GETDATE()," + matchingUserId + ")";
                    SqlCommand cmd4 = new SqlCommand(messageQuery4, sqlConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    adapter.InsertCommand = cmd4;
                    adapter.InsertCommand.ExecuteNonQuery();

                    cmd4.Dispose();

                    reader.Close();

                   
                }
                    
            }
            MessageBox.Show("Messages sent successfully");

            reader.Close();

            //inserting into the recepients table
            List<string> list2 = new List<string>();
                    string IDOutput = "";
                    string msgIDQuery = "Select MessageId from Messages where SenderId = " + user.ID + "";
                    SqlCommand commandID = new SqlCommand(msgIDQuery, sqlConnection);
                    
                    reader = commandID.ExecuteReader();

                    while (reader.Read())
                    {
                        IDOutput = IDOutput + reader.GetValue(0) + " \n";

                    }                 
                    string[] list = IDOutput.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    reader.Close();
            foreach (string item in list)
            {
                string query2 = "Insert into Recipients (UserId, MessageId) values ("+user.ID+", "+item+")";
                SqlCommand insertCommandIdk = new SqlCommand(query2,sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = insertCommandIdk;
                adapter.InsertCommand.ExecuteNonQuery();

            }


            reader.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        //metohd to load list of users
        public void idkwhatIamDoin()
        {


            SqlCommand command;
            SqlDataReader reader;

            string query = "";
            string output = "";

            query = "Select UserName from Users";
            command = new SqlCommand(query, sqlConnection);

            //Reading from database 
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                output = output + reader.GetValue(0) + "\n";
            }

            string[] list = output.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in list)
            {
                listOfUsers.Items.Add(item);
            }
            reader.Close();

            LoadUsers.Enabled = false;

        }

        private void MessageHistory_Click(object sender, EventArgs e)
        {
            History historyForm = new History(user);
            historyForm.Show();
            Visible = false;

        }
    }
}
