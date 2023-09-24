using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint1.Task2.V24.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateDiffSquare()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 2;
            int wait = 21;
            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
