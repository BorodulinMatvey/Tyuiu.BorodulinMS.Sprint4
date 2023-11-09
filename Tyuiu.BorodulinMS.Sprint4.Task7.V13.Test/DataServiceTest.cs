using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Task7.V13.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "159357246";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
