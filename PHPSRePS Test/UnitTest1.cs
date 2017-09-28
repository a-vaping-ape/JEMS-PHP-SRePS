using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PHPSRePS;

namespace PHPSRePS_Test
{
    [TestClass]
    public class UnitTest1
    {
        Database db;
        Product product1, product2, product3;
        Sale sale1, sale2, sale3;

        [SetUp]
        public void Init()
        {
            db = new Database();
        }

        [TestMethod]
        public void TestDBConnection()
        {
            db = new Database();
            string output = db.TestConnection();
            NUnit.Framework.Assert.AreEqual("1", output);
        }

        [TestMethod]
        public void AddProductTest()
        {

        }
    }
}
