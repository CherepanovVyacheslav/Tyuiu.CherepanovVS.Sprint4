using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint4.Task6.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var browse = new string[] { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
            int res = ds.Calculate(browse);
            int wait = 4;
            Assert.AreEqual(res, wait);

        }
    }
}
