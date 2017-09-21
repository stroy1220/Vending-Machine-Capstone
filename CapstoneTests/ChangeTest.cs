using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]
        public void DoWeGetBackCorrect()
        {
            Change money = new Change(1.15M);
            int quarters = money.Quarters;
            int dimes = money.Dimes;
            int nickles = money.Nickels;
            Assert.AreEqual(4, quarters);
            Assert.AreEqual(1, dimes);
            Assert.AreEqual(1, nickles);

            Assert.AreEqual( 1.15, money.TotalChange);

        }
        
        [TestMethod]
        public void DoWeGetBack3InCents()
        {
            Change money = new Change(.90M);
            int quarters = money.Quarters;
            int dimes = money.Dimes;
            int nickles = money.Nickels;
            Assert.AreEqual(3, quarters);
            Assert.AreEqual(1, dimes);
            Assert.AreEqual(1, nickles);


            Assert.AreEqual(.90, money.TotalChange);
        }
        
    }
}
