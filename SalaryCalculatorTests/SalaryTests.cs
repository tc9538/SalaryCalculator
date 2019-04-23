using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace SalaryCalculatorTests
{
    [TestClass]
    public class SalaryTests
    {
        [TestMethod]
        public void TestSalary()
        {
            Salary s = new Salary();
            s.setHourlyRate(10);
            s.setTotalHours(40);
            s.salaryCalculator();
            Assert.AreEqual(400, s.getCalculatedSalary());
        }

        [TestMethod]
        public void TestAnotherSalary()
        {
            Salary s = new Salary();
            s.setHourlyRate(21.5);
            s.setTotalHours(40);
            s.salaryCalculator();
            Assert.AreEqual(860, s.getCalculatedSalary());
        }


    }
}
