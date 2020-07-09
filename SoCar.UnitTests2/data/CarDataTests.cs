using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data.Tests
{
    [TestClass()]
    public class CarDataTests
    {
        [TestMethod()]
        public void Get()
        {
            Car car = DataRepository.Car.Get(1);
            Assert.AreEqual("52하3028", car.Number);

        }

        [TestMethod()]
        public void Search()
        {
            List<Car> cars = DataRepository.Car.Search(null, null, null, true);
            Assert.IsTrue(cars.Count > 0);
        }



    }
}