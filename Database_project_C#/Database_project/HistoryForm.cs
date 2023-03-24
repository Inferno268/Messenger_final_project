using System;
using System.Collections;
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

namespace Database_project
{
    public partial class History : Form
    {
        static string conn = ConfigurationManager.ConnectionStrings["justDatabase"].ConnectionString;
        SqlConnection sqlConnection = DatabaseSingleton.GetInstance();

        int temp = 0;
        private MyUser user;

        public History(MyUser user)
        {
            InitializeComponent();
            this.user = user;
        }
        //loading sent messages
        private void LoadHistory_Click(object sender, EventArgs e)
        {
            string query = "Select MessageId, Subject, Body, CreatedAt, receiverId from Messages where SenderId = " + user.ID + "";
            string output = "";

            SqlDataReader reader;
            SqlCommand command = new SqlCommand(query, sqlConnection);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                output = output + "MessageId : " + reader.GetValue(0) + " Subject : " + reader.GetValue(1) + " Body : " + reader.GetValue(2) + " Date : " + reader.GetValue(3) + " Receiver : " + "\n";


            }
            string[] list = output.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in list)
            {
                listOfMessages.Items.Add(item);
            }
            reader.Close();

            LoadHistory.Enabled = false;
        }

        private void listOfMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //loading recived messages
        private void loadRecievedMessages_Click(object sender, EventArgs e)
        {
            string query = "Select MessageId, SenderId, Subject, Body, CreatedAt, receiverId from Messages where receiverId = " + user.ID + "";
            string output = "";

            SqlDataReader reader;
            SqlCommand command = new SqlCommand(query, sqlConnection);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                output = output + "MessageId : " + reader.GetValue(0) + " SenderId : " + reader.GetValue(1) + " Subject : " + reader.GetValue(2) + " Body : " + reader.GetValue(3) + " Date : " + reader.GetValue(4) + " Receiver : " + reader.GetValue(5) + "\n";


            }
            string[] list = output.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in list)
            {
                listOfRecievedMessages.Items.Add(item);
            }
            reader.Close();

            loadRecievedMessages.Enabled = false;
        }
        private void DeleteMessages_Click(object sender, EventArgs e)
        {
            if (listOfMessages.CheckedItems.Count > 0)
            {
                // Loop through the checked items
                foreach (var item in listOfMessages.CheckedItems)
                {
                    string checkedItem = item.ToString();

                    int index = checkedItem.IndexOf("MessageId : ");

                    if (index != -1)
                    {
                        string number = checkedItem.Substring(index + 12);

                        int spaceIndex = number.IndexOf(" ");

                        if (spaceIndex != -1)
                        {
                            // Get the number before " "
                            number = number.Substring(0, spaceIndex);
                            MessageBox.Show(number);
                        }


                        int messageId = int.Parse(number);

                        string query = "Delete FROM Recipients WHERE UserId = " + user.ID + " AND MessageId = " + messageId;

                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.ExecuteNonQuery();


                        MessageBox.Show("Message/s deleted succesfully");
                    }
                }
            }

        }

        private void listOfRecievedMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainPageForm mainPage = new MainPageForm(user);
            mainPage.Show();
            Visible = false;
        }
    }
}

