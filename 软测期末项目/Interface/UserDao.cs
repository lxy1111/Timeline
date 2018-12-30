using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.entity;
using Timeline.Interface;

namespace Timeline.Interface
{
    public interface UserDao
    {
        bool checkRegister(User user);
         bool checkLogin(User user);
        void registerUser(User user);
     
    }
}
