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
    public class RentDataTests
    {
        [TestMethod()]
        public void Get()
        {
            Rent rent = DataRepository.Rent.Get(8);
            Assert.AreEqual(48000, rent.Price);
        }

        [TestMethod()]
        public void Search()
        {
            List<Rent> rents = DataRepository.Rent.Search(null,2,null,null,null);
            Assert.IsTrue(rents.Count > 0);
        }
    }
}