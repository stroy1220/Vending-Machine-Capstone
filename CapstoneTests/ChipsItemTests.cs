using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ChipsItemTests
    {
        [TestMethod]
        public void ChipsConsume()
        {

            ChipsItem chips = new ChipsItem("BBQ", 1.00M);

            Assert.AreEqual("Crunch Crunch, Yum!", chips.Consume());

        }

        [TestMethod]
        public void ChipsName()
        {
            ChipsItem chips = new ChipsItem("Lays", 1.00M);

            Assert.AreEqual("Lays", chips.Name);
        }

        [TestMethod]
        public void ChipsAmount()
        {
           ChipsItem chip = new ChipsItem("Doritos", 1.10M);

            Assert.AreEqual(1.10M, chip.Cost);
        }


    }
}
