using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PHPSRePS;

namespace PHPSRePS_Test
{
    [TestClass]
    public class UnitTest1
    {
        Database database;
        Product product1, product2, product3;
        Sale sale1, sale2, sale3;

        // db info
        private string server = "110.22.43.149";
        private string databaseName = "hawthornpharmacy";
        private string adminUser = "admin";
        private string adminPass = "dp22017";

        [SetUp]
        public void Init()
        {
            database = new Database(server, adminUser, adminPass, databaseName);
        }

        [TestMethod]
        public void AddProductTest()
        {

        }
    }
}
