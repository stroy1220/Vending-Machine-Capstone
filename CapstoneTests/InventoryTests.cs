using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void AmountOfInvItems()
        {
            ReadInInventory monkey = new ReadInInventory(@"C:\Users\Samantha Troy\Desktop\c - module - 1 - capstone - team - 7\etc\vendingmachine.csv");
            //int inv =monkey.GetInventory();


            Assert.AreEqual(16, monkey.GetInventory().Count);
            
        }
    }
}
