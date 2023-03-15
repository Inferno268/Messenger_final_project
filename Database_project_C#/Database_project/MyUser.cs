using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Database_project
{
    public class MyUser
    {
        public int ID;
        public string userName;
        public string password;

        // constructor
        public MyUser(int ID, string userName, string password)
        {
            this.ID = ID;
            this.userName = userName;
            this.password = password;
        }
        

       /* public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }


        public int GetID()
        {
            return ID;
        }

        public void SetID(int id)
        {
            ID = id;
        }
       */
    }
}
