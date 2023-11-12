using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint4.Task5.V8.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -1, 3, 7, 7, 6 }, { 4, -2, 6, 3, 3 }, { 4, 5, 1, 4, -6 }, { 7, -5, 2, 7, 7 }, { 2, 4, 4, -4, 7 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 0, 3, 7, 7, 6 }, { 4, 0, 6, 3, 3 }, { 4, 5, 1, 4, 0 }, { 7, 0, 2, 7, 7 }, { 2, 4, 4, 0, 7 } };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
