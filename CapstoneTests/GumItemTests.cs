using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class GumItemTests
    {
        [TestMethod]
        public void GumConsume()
        {
            GumItem gum = new GumItem("Trident", 1.00M);

            Assert.AreEqual("Chew Chew, Yum!", gum.Consume());
        }

        [TestMethod]
        public void GumName()
        {
            GumItem chewy = new GumItem("Trident", 1.00M);

            Assert.AreEqual("Trident", chewy.Name);
        }

        [TestMethod]
        public void GumAmount()
        {
            GumItem chewy = new GumItem("Hubba Bubba", .85M);

            Assert.AreEqual(.85M, chewy.Cost);
        }
    }
}
