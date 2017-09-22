using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTests
    {
        [TestMethod]
        public void GetItemAtSlot()
        {
            //string filepath = "vendingmachine.csv";
            VendingMachine vend = new VendingMachine();
            vend.FeedMoney(400);
            
            //vend.GetItemAtSlot;
           

            Assert.AreEqual("Stackers" ,vend.GetItemAtSlot("A2").Name);

        }
        [TestMethod]
        public void CanWeBuy()
        {
            VendingMachine test = new VendingMachine();
            test.FeedMoney(400);
            test.Purchase("A1");

            Assert.AreEqual("Potato Crisps", test.GetItemAtSlot("A1").Name);

        }
        [TestMethod]
        public void CurrentBalance()
        {
            VendingMachine test = new VendingMachine();
            test.FeedMoney(4);
            test.Purchase("C3");
            Assert.AreEqual(2.50M, test.CurrentBalance);
        }
        [TestMethod]
        public void ReturnChange()
        {

            VendingMachine test = new VendingMachine();
            test.FeedMoney(4);
            test.Purchase("C2");
            test.ReturnChange();

            Assert.AreEqual(0, test.CurrentBalance);

        }

    }
}
