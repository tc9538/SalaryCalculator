using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace SalaryCalculatorTests
{
    [TestClass]
    public class PTOTests
    {
        [TestMethod]
        public void TestGetPTO()
        {
            PTOs t = new PTOs();
            Assert.AreEqual(80, t.getCurrentTotalPTOs());
        }

        [TestMethod]
        public void TestGetPTOLeft()
        {
            PTOs t = new PTOs();
            t.usePTO(10);
            Assert.AreEqual(70, t.getCurrentTotalPTOs());
        }

        [TestMethod]
        public void TestGetPTOByName()
        {
            PTOs t = new PTOs();
            t.getPTOByName("Truc");
            Assert.AreEqual(80, t.getCurrentTotalPTOs());
        }


    }
}
