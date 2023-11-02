using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Task2.V24.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4,5,6,7,8,9,7,8,9,5,7,4 };
            int res = ds.Calculate(numsArray);
            int Wait = 49;
            Assert.AreEqual(Wait, res);
        }
    }
}
