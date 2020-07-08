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
    public class EventDataTests
    {
        [TestMethod()]
        public void Get()
        {
            Event @event = DataRepository.Event.Get(7);
            Assert.AreEqual(202, @event.EventTypeCode);
        }

        [TestMethod()]
        public void getByCodeId()
        {
            List<Event> events = DataRepository.Event.getByCodeId(202);
            Assert.IsTrue(events.Count > 0);
        }

        [TestMethod()]
        public void Search()
        {
            List<Event> events = DataRepository.Event.Search(202,null);
            Assert.IsTrue(events.Count > 0);
        }
    }
}