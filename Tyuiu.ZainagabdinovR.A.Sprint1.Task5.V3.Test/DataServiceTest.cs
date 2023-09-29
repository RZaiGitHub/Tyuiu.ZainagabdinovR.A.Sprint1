using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int k = 130985;
            var res = ds.Calculate(k);
            Assert.AreEqual(13098.5, res);
        }
    }
}
