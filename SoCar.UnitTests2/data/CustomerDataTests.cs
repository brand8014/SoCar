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
    public class CustomerDataTests
    {
        [TestMethod()]
        public void Get()
        {
            Customer customer = DataRepository.Customer.Get(7);
            Assert.AreEqual("박보검", customer.Name);
        }

        [TestMethod()]
        public void Search()
        {
            List<Customer> customers = DataRepository.Customer.Search(null,null,null,701);
            Assert.IsTrue(customers.Count > 0);
        }
    }
}