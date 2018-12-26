using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeline.Interface
{
    public interface observer
    {
        void update();
        string getobserverusername();
        string getobserverpassword();
        void setobserverusername(string username);
        void setobserverpassword(string password);
    }
}
