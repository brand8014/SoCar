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
    public class DefectDataTests
    {
        [TestMethod()]
        public void Get()
        {
            Defect defect = DataRepository.Defect.Get(6);
            Assert.AreEqual(304, defect.PartCode);
        }

        [TestMethod()]
        public void GetAll()
        {
            List<Defect> defects = DataRepository.Defect.GetAll();
            Assert.IsTrue(defects.Count > 0);
        }

        [TestMethod()]
        public void GetCount()
        {
            int testItem = DataRepository.Defect.GetCount();
            Assert.IsTrue(testItem > 0);
        }

        [TestMethod()]
        public void Insert()
        {
            int oldCount = DataRepository.Defect.GetCount();

            Defect defect = new Defect();
            defect.PartCode = 303;
            defect.DefectStateCode = 401;
            defect.CarId = 5;
            DataRepository.Defect.Insert(defect);

            int newCount = DataRepository.Defect.GetCount();

            Assert.AreEqual(oldCount + 1, newCount);
        }

        [TestMethod()]
        public void Delete()
        {
            Defect defect = new Defect();
            defect.PartCode = 303;
            defect.DefectStateCode = 401;
            defect.CarId = 5;
            DataRepository.Defect.Insert(defect);

            int oldCount = DataRepository.Defect.GetCount();

            int maxAlbumId = DataRepository.Defect.GetMaxId();
            DataRepository.Defect.Delete(maxAlbumId);

            int newCount = DataRepository.Defect.GetCount();

            Assert.AreEqual(oldCount - 1, newCount);

        }

        [TestMethod()]
        public void GetMaxId()
        {
            var testItem = DataRepository.Defect.GetMaxId();
            Assert.AreEqual(6,testItem);
        }

        [TestMethod()]
        public void Update()
        {
            Defect defect = DataRepository.Defect.Get(1);
            int oldPartCode = defect.PartCode;

            defect.PartCode = 302;

            DataRepository.Defect.Update(defect);

            defect = DataRepository.Defect.Get(1);

            Assert.AreNotEqual(oldPartCode, defect.PartCode);
        }
    }
}