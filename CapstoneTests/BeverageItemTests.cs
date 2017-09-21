using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class BeverageItemTests
    {
        [TestMethod]
        public void BeverageConsume()
        {
            BeverageItem drink = new BeverageItem("tea", 1.00M);

            Assert.AreEqual("Glug Glug, Yum!", drink.Consume());

        }

        [TestMethod]
        public void BeverageName()
        {
            BeverageItem pop = new BeverageItem("Dr.Pepper", 1.00M);

            Assert.AreEqual("Dr.Pepper", pop.Name);
        }

        [TestMethod]
        public void BeverageAmount()
        {
            BeverageItem pop = new BeverageItem("Dr.Pepper", 1.00M);

            Assert.AreEqual(1.00M, pop.Cost);
        }

    }
}
