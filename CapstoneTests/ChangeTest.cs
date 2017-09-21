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
            Change money = new Change(75);

            Assert.AreEqual(3, money.Quarters);
        }
        [TestMethod]
        public void DoWeGet9InCents()
        {
            Change money = new Change(90);
            Assert.AreEqual(9, money.Dimes);

        }
        [TestMethod]
        public void DoWeGet16inCents()
        {
            Change money = new Change(80);
            Assert.AreEqual(16, money.Nickels);

        }
    }
}
