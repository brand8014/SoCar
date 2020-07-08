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
    public class CarTypeDataTests
    {
        [TestMethod()]
        public void Get()
        {
            CarType carType = DataRepository.CarType.Get(1);
            Assert.AreEqual("마티즈", carType.Name);
        }
    }
}