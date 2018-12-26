using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using Timeline.entity;
using Timeline.Interface;
using Timeline.server;


namespace Timeline.server
{
   public   class userserver: observerable
    {
        private MySqlConnection conn;
        private Database db;
        private List<Message> newsList;

        public userserver()
        {
            newsList = new List<Message>();
            db=new Database();
            conn = db.connection(); 
        }

        public List<Message> getAllNews()
        {
            conn.Open();
            try
            {
                string sql = "select * from news,users where news.author=users.username";
                var str = new MySqlCommand(sql, conn);
                var rs = str.ExecuteReader();
                while (rs.Read())
                {
                    string message = rs.GetString("content");
                    string ImageURL = rs.GetString("ImageURL");
                    string username = rs.GetString("author");
                    string password = rs.GetString("password");
                    string posttime = rs.GetString("posttime");
                    User user = new User(username, password);
                    Message news=new Message(message,ImageURL,posttime,user);
                    newsList.Add(news);
                }
                rs.Close();
                return newsList;
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

            return null;
        }


        public bool checkRegister(observer observer)
        {
            conn.Open();
            try
            {
                string sql = "select * from users where username='" + observer.getobserverusername() +
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




        public bool checklogin(observer observer)
        {
            conn.Open();
            try
            {
                string sql = "select * from users where username='" + observer.getobserverusername() +
                             "' and password='" + observer.getobserverpassword() + "'";
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

        public bool registerobserver(observer observer)
        {
            conn.Open();
            try
            {
                string sql = "insert into users values('" + observer.getobserverusername() + "','" +
                             observer.getobserverpassword() + "')";

                var sqlstr = new MySqlCommand(sql, conn);
                sqlstr.ExecuteNonQuery();
                MessageBox.Show("注册成功！");
                return true;
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

        public bool publishMessage(Message message)
        {
            conn.Open();
            try
            {
                int id=0;
                string sql1 = "select id from count";
                var sqlstr1=new MySqlCommand(sql1,conn);
                var rs=sqlstr1.ExecuteReader();
                while (rs.Read())
                {
                    id = rs.GetInt16("id");
                }
                rs.Close();

                string sql2 = "update count set id='" + (id + 1) + "'";
                var sqlstr2=new MySqlCommand(sql2,conn);
                sqlstr2.ExecuteNonQuery();
            
                string sql = "insert into news values('"+(id+1) +"','"+ message.getContent() + "','" +
                             message.getImageURL() + "','"+message.getUser().getobserverusername()+"','"+message.getPosttime()+"')";

                var sqlstr = new MySqlCommand(sql, conn);
                sqlstr.ExecuteNonQuery();
                MessageBox.Show("发布成功！");
                return true;
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

        public bool removeobserver(observer observer)
        {
            return false;
        }

 
        public bool notifyobserver()
        {
            return false;

        }


    }
}
