using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timeline.server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Moq;  
using MySql.Data.MySqlClient;
using Timeline.entity;
using Timeline.Interface;

namespace Timeline.server.Tests
{
    [TestClass()]
    public class UserServerTests
    {
        private IUserDao server;
        private IDatabase db;
        private Mock<IDatabase> mockDb;
        [TestInitialize]
        public void Setup()
        {
            mockDb = new Mock<IDatabase>();
            db = mockDb.Object;
            server = new UserDao(db);
        }

        [TestMethod()]
        public void CheckRegisterTest()
        {
            User user = new User("lxy1", "12345");
            IDataParameter theParameter = new MySqlParameter();
            mockDb.Setup(d => d.CreateParameter("USER_NAME", user.UserName)).Returns(theParameter);
            mockDb.Setup(d => d.ExecuteScalar(UserDao.CheckRegisterSql, theParameter)).Returns(true);
            server.CheckRegister(user);
            mockDb.VerifyNoOtherCalls();
        }
        
        
    }
}