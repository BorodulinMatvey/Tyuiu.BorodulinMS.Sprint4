using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Task1.V3.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4,8,8,9,6,5,3,2,9,7,7,7 };
            int res = ds.Calculate(numsArray);
            int Wait = 3072;
            Assert.AreEqual(Wait, res);
        }
    }
}
