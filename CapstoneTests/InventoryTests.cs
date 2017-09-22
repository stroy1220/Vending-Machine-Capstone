using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.IO;

namespace CapstoneTests
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void AmountOfInvItems()
        {
                        
            string filepath = "vendingmachine.csv";
            //
            ReadInInventory monkey = new ReadInInventory(filepath);



            Assert.AreEqual(16, monkey.GetInventory().Count);
            
        }
    }
}
