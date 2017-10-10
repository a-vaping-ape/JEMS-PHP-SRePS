using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PHPSRePS;
using System.Collections.Generic;


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
        public void HasSQLTable()
        {
            db = new Database();
            string output = db.TestConnection();
            //NUnit.Framework.Assert.AreEqual("1", output);
        }

        [TestMethod]
        public void ProductUpdate()
        {
            db = new Database();

            product1 = new Product();

            product1.ID = 1;
            product1.Name = "test";
            product1.Price = (float)9.8;
            product1.Stock = 10;
            product1.IsDiscontinued = false;

            string query = product1.GetUPDATE();

           // NUnit.Framework.Assert.AreEqual("UPDATE Products SET ProductName ='test', UnitPrice = '9.8', U" +
             //   "nitsInStock = '10',IsDiscontinued = '0' WHERE Product='1';", query);


            db.RunVoidQuery(query);

            



        }

        [TestMethod]
        public void INSERTSaleInDB()
        {
            db = new Database();
            sale1 = new Sale();

            bool pass = db.RunVoidQuery(sale1.GetINSERT());
            
            NUnit.Framework.Assert.AreEqual(true, pass);
        }

        [TestMethod]
        public void CategoryNames()
        {
            db = new Database();
   

            List<String> result = db.GetCategoires();

            NUnit.Framework.Assert.AreEqual(6, result.Count);

           // bool pass = db.RunVoidQuery(sale1.GetINSERT());

            //NUnit.Framework.Assert.AreEqual(true, pass);
        }
    }
}
