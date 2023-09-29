using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint1.Task6.V4.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Задействованая";
            DataService ds = new DataService();
            var res = ds.CheckDoubleN(strTest);
            string wait = "Задействованная";
            Assert.AreEqual(wait, res);
        }
    }
}
