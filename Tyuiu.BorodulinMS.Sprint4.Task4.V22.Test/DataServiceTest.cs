using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Task4.V22.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void a()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { {4,3,2,4,5}, { 5, 4, 5, 6, 6 },{ 6,2,3,6,5},{ 6,2,3,6,4},{ 6,2,6,6,2} };

            int[,] res = ds.Calculate(mas2);
            int [,] wait = new int[5, 5] { { 4,0,2,4,0},{ 0, 4, 0, 6, 6 }, { 6, 2, 0, 6, 0 }, { 6, 2, 0, 6, 4 }, { 6, 2, 6, 6, 2 } };
            CollectionAssert.AreEqual(wait, res);


        }
    }
}
