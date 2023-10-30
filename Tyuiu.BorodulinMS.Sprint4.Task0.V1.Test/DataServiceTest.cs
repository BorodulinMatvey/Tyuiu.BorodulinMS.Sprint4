﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Task0.V1.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int Wait = 20;
            Assert.AreEqual(Wait, res);
        }
    }
}
