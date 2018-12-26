using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Timeline.server
{
    class Database
    {
        private MySqlConnection db;


        public Database()
        {
            var constr = "server=localhost;port=3306;User Id=root;password=123456;Database=timeline;charset=utf8";
            db =new MySqlConnection(constr);
        }

        public MySqlConnection connection()
        {
            return this.db;
        }

    }
}
