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
                output = output +"MessageId : "+reader.GetValue(0)+ " SenderId : " + reader.GetValue(1)+ " Subject : " + reader.GetValue(2) + " Body : " + reader.GetValue(3) + " Date : " + reader.GetValue(4) + " Receiver : " + reader.GetValue(5) +"\n";


            }
            string[] list = output.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in list)
            {
                listOfRecievedMessages.Items.Add(item);
            }
            reader.Close();
        }
        //deleting records from database
        private void DeleteMessages_Click(object sender, EventArgs e)
        {
            foreach(string item in listOfMessages.CheckedItems) {
                
                string[] inputLines = item.Split('\n');
                string[] columnNames = inputLines[0].Split('\t');
                string[] dataValues = inputLines[0].Split('\t');

                int senderId = int.Parse(dataValues[Array.IndexOf(columnNames, "SenderId")]);

                MessageBox.Show("SenderId: " + senderId);
                string query = "Delete from Recepients where SenderId = " + senderId + "";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
            }
          
        }
    }
}
