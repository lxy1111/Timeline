using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timeline.server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.entity;

namespace Timeline.server.Tests
{
    [TestClass()]
    public class userserverTests
    {
        private userserver server = new userserver();

        [TestMethod()]
        public void checkRegisterTest()
        {
            User user = new User("lxy1", "12345");
            User user2 = new User("lxy2", "111");
            Assert.AreEqual(server.checkRegister(user), true);
            Assert.AreEqual(server.checkRegister(user2), false);
        }

        [TestMethod()]
        public void checkloginTest()
        {
            User user1 = new User("lxy1", "1234");
            User user2 = new User("lxy1", "12345");
            Assert.AreEqual(server.checklogin(user1), false);
            Assert.AreEqual(server.checklogin(user2), true);
        }

        [TestMethod()]
        public void registerobserverTest()
        {
           User user1=new User("lxy","111");
           Assert.AreEqual(server.registerobserver(user1),true);
        }



    }
}