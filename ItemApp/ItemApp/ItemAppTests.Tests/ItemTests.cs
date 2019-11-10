using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItemApp;

namespace ItemAppTests.Tests
{
    [TestClass]
    public class ItemTests
    {

        [TestMethod]
        public void TestConstructItem()
        {
            var itemNo = 1111;
            var description = "Water";
            var unitOfMeasure = "GALLON";
            var weight = 5.0;

            var item = new Item(itemNo, description, unitOfMeasure, weight);

            Assert.AreEqual(itemNo, item.GetItemNo());
            Assert.AreEqual(description, item.GetDescription());
            Assert.AreEqual(unitOfMeasure, item.GetUnitOfMEasure());
            Assert.AreEqual(weight, item.GetWeight());
        }

    }
}
