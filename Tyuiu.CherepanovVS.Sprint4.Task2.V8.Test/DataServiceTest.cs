using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint4.Task2.V8.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[]numsArray = { 3, 6, 5, 3, 2,5,4,3,5,3,4 };
            int res = ds.Calculate(numsArray);
            int wait = 27;
            Assert.AreEqual(res, wait);
        }
    }
}
