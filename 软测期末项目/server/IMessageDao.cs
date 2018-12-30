using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using Timeline.entity;
using Timeline.Interface;
using Timeline.server;

namespace 软测期末项目.server
{
  public  class IMessageDao: MessageDao
    {
        private MySqlConnection conn;
        private Database db;
        private List<Message> newsList;

        public IMessageDao()
        {
            newsList = new List<Message>();
            db = new Database();
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
                    Message news = new Message(message, ImageURL, posttime, user);
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

        public bool publishMessage(Message message)
        {
            conn.Open();
            try
            {
                string sql = "insert into news(content,imageURL,author,posttime) values('" + message.getContent() + "','" +
                             message.getImageURL() + "','" + message.getUser().getUserName() + "','" + message.getPosttime() + "')";

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

    }
}
