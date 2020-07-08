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

        [TestMethod()]
        public void SearchWithCarName()
        {
            List<Car> cars = DataRepository.Car.SearchWithCarName(1, null, null, null);

            List<string> carNames = new List<string>();

            foreach (var item in cars)
            {
                carNames.Add(item.CarName);
            }

            Assert.IsTrue(carNames[0] == "마티즈");

            // Assert.IsTrue(carNames.Any(x => x.Contains("마티즈")));
        }

        [TestMethod()]
        public void SearchWithCarNameAndAddress()
        {
            List<Car> cars = DataRepository.Car.SearchWithCarNameAndAddress(1);

            Assert.IsTrue(cars[0].CarName == "마티즈" && cars[0].Address == "화곡역주차장");
        }
    }
}