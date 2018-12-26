using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.Interface;
using Timeline.server;


namespace Timeline.entity
{
   public  class User  : observer
    {
        private string username;
        private string userpassword;

      
      
        public  User(string username,string password)
        {
            this.username = username;
            this.userpassword = password;
        }

      public  string getobserverusername()
      {
          return username;
      }

        public string getobserverpassword()
        {
            return userpassword;
        }

        public void setobserverusername(string username)
        {
            this.username = username;
        }

        public void setobserverpassword(string password)
        {
            this.userpassword = password;
        }

   
        public void update()
        {
           
        }



    }
}
