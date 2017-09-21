using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class CandyItemTests
    {
        [TestMethod]
        public void CandyConsume()
        {
            CandyItem snack = new CandyItem("KitKat", 1.00M);

            Assert.AreEqual("Munch Munch, Yum!", snack.Consume());
        }

        [TestMethod]
        public void CandyName()
        {
            CandyItem snack = new CandyItem("Crunch", 1.00M);

            Assert.AreEqual("Crunch", snack.Name);
        }

        [TestMethod]
        public void CandyAmount()
        {
            CandyItem candy = new CandyItem("Crunch", 1.55M);

            Assert.AreEqual(1.55M, candy.Cost);
        }
    }
}
