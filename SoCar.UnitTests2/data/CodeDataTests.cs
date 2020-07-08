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
    public class CodeDataTests
    {
        [TestMethod()]
        public void Get()
        {
            Code code = DataRepository.Code.Get(301);
            Assert.AreEqual("범퍼", code.Item);
        }

        [TestMethod()]
        public void GetByCodeCategoryId()
        {
            List<Code> codes = DataRepository.Code.GetByCodeCategoryId(1);
            Assert.IsTrue(codes.Count > 0);
        }
    }
}