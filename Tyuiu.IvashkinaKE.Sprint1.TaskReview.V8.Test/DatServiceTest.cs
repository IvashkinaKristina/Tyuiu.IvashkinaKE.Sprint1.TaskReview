using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint1.TaskReview.V8.Lib;

namespace Tyuiu.IvashkinaKE.Sprint1.TaskReview.V8.Test
{
    [TestClass]
    public class DatServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double wait = 2.793;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
