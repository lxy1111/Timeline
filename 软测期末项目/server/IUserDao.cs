using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Castle.Components.DictionaryAdapter.Xml;
using MySql.Data.MySqlClient;
using Timeline.entity;
using Timeline.Interface;
using Timeline.server;


namespace Timeline.server
{
   public   class IUserDao: UserDao
    {
        private MySqlConnection conn;
        private Database db;
        private List<Message> newsList;

        public IUserDao()
        {
            newsList = new List<Message>();
            db=new Database();
            conn = db.connection(); 
        }



        public bool checkRegister(User user)
        {
            conn.Open();
            try
            {
                string sql = "select * from users where username='" + user.getUserName() +
                             "'";
                var str = new MySqlCommand(sql, conn);
                var rs = str.ExecuteReader();
                if (rs.Read())
                {
                    rs.Close();
                    return true;
                }

                rs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return false;
        }




        public bool checkLogin(User user)
        {
            conn.Open();
            try
            {
                string sql = "select * from users where username='" + user.getUserName() +
                             "' and password='" + user.getUserPassword() + "'";
                var str = new MySqlCommand(sql, conn);
                var rs = str.ExecuteReader();
                if (rs.Read())
                {
                    rs.Close();
                    return true;
                }

                rs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return false;
        }

        public void registerUser(User user)
        {
            conn.Open();
            try
            {
                string sql = "insert into users values('" + user.getUserName() + "','" +
                             user.getUserPassword() + "')";
                MySqlCommand sqlstr=new MySqlCommand();
                sqlstr.Connection = conn;
                sqlstr.CommandText = sql;
                    // var sqlstr = new MySqlCommand(sql, conn);
                sqlstr.ExecuteNonQuery();
                MessageBox.Show("注册成功！");
                return ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            { 
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return ;
        }

     

 

    }
}
