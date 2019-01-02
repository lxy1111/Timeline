using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Timeline.entity;
using 软测期末项目.server;

namespace Timeline.server.Tests
{
    [TestClass]
    public class MessageDaoTest
    {
        [TestMethod]
        public void GetAllNewsTest()
        {
            var mockDb = new Mock<IDatabase>();
            var sut = new MessageDao(mockDb.Object);
            var expected = new List<Message>();
            mockDb.Setup(db => db.ExecuteReader(MessageDao.SelectSql, sut.LoadMessages)).Returns(expected);
            var actual = sut.GetAllNews();
            Assert.Equals(expected, actual);
            mockDb.VerifyAll();
        }

        [TestMethod]
        public void LoadMessagesTest()
        {
            /*
             * var message = reader["content"] as string;
                var imageUrl = reader["ImageURL"] as string;
                var username = reader["author"] as string;
                var password = reader["password"] as string;
                var posttime = reader["posttime"] as string;
             */
            var user = new User("username", "password");
            var news = new Message("message", "imageUrl", "post_time", user);
            var mockDataReader = new Mock<IDataReader>();
            mockDataReader.Setup(r => r["content"]).Returns(news.Content);
            mockDataReader.Setup(r => r["ImageURL"]).Returns(news.ImageUrl);
            mockDataReader.Setup(r => r["author"]).Returns(user.UserName);
            mockDataReader.Setup(r => r["password"]).Returns(user.UserPassword);
            mockDataReader.Setup(r => r["posttime"]).Returns(news.PostTime);
            var mockDb = new Mock<IDatabase>();
            var sut = new MessageDao(mockDb.Object);
            var actual = sut.LoadMessages(mockDataReader.Object);
            Assert.Equals(1, actual.Count);
            var actualNews = actual[0];
            Assert.Equals(news.Content, actualNews.Content);
            //.......
        }
    }
}