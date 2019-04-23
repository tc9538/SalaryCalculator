using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace SalaryCalculatorTests
{
    [TestClass]
    public class ContractTests
    {
        [TestMethod]
        public void TestGetContractEndDate()
        {
            Contract ct = new Contract();
            String s = "01/30/2020";
            ct.setContractEndDate(s);
            Assert.AreEqual(s,ct.getContractEndDate());
        }

        [TestMethod]
        public void TestNotEqualContractEndDate()
        {
            Contract ct = new Contract();
            String s = "01/30/1998";
            ct.setContractEndDate(s);
            Assert.AreNotEqual("02/03/1990", ct.getContractEndDate());
        }
    }
}
