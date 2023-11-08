using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Task5.V5.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -4, 3, 4, 5, 7 }, { -3, 1, 2, 3, 4 }, { 1, 2, 3, 4, 5 }, { -4, 2, 5, 6, 4 }, { 2, 4, 5, 3, 1 } };
            int res = ds.Calculate(mas2);
            int wait = 76;
            Assert.AreEqual(wait, res);
        }
    }
}
