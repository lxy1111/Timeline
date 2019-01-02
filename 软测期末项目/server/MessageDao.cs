using System;
using System.Collections.Generic;
using System.Data;
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
    public class MessageDao : IMessageDao
    {
        private IDatabase db;
        internal const string SelectSql = "select * from news,users where news.author=users.username";

        public MessageDao(IDatabase db)
        {
            this.db = db;
        }

        public List<Message> GetAllNews()
        {
            string sql = "select * from news,users where news.author=users.username";
            return db.ExecuteReader(sql, this.LoadMessages);
        }

        internal List<Message> LoadMessages(IDataReader reader)
        {
            var newsList = new List<Message>();
            while (reader.Read())
            {
                var message = reader["content"] as string;
                var imageUrl = reader["ImageURL"] as string;
                var username = reader["author"] as string;
                var password = reader["password"] as string;
                var posttime = reader["posttime"] as string;
                var user = new User(username, password);
                var news = new Message(message, imageUrl, posttime, user);
                newsList.Add(news);
            }

            return newsList;
        }

        public bool PublishMessage(Message message)
        {
            var sql =
                "insert into news(content,imageURL,author,posttime) values(@CONTENT, @IMAGE_URL, @USER_NAME, @POST_TIME)";
            try
            {
                db.ExecuteNonQuery(sql,
                    db.CreateParameter("CONTENT", message.Content),
                    db.CreateParameter("IMAGE_URL", message.ImageUrl),
                    db.CreateParameter("USER_NAME", message.User?.UserName),
                    db.CreateParameter("POST_TIME", message.PostTime));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}