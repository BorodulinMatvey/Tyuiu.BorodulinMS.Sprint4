using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Task6.V18.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var  pats = new string[] { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            string []res = ds.Calculate(pats);
            string[] wait = { "Попугай", "Черепаха" };
            CollectionAssert.AreEqual (wait, res);
        }
    }
}
