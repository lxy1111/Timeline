using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.Interface;
using Timeline.server;


namespace Timeline.entity
{
   public  class User 
    {
        private string userName;
        private string userPassword;

      
      
        public  User(string username,string password)
        {
            this.userName = username;
            this.userPassword = password;
        }

      public  string getUserName()
      {
          return userName;
      }

        public string getUserPassword()
        {
            return userPassword;
        }

    
  

    }
}
