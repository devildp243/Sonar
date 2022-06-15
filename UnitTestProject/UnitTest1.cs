using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            democlass obj = new democlass();
            Assert.AreEqual("durga", obj.fname);
            Assert.AreEqual("prasad", obj.lname);
        }
    }
}
