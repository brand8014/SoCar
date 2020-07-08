using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data.Tests
{
    [TestClass()]
    public class LocationDataTests
    {
        [TestMethod()]
        public void Get()
        {
            Location location = DataRepository.Location.Get(1);
            Assert.AreEqual("화곡역주차장", location.Address);
        }

        [TestMethod()]
        public void GetFirstId()
        {
            int? testItem = DataRepository.Location.GetFirstId();
            Assert.AreEqual(1, testItem);
        }

        [TestMethod()]
        public void GetByCodeCategory()
        {
            List<Location> locations = DataRepository.Location.GetByCodeCategory(101);

            Assert.IsTrue(locations.Count > 0);
        }

    }
}