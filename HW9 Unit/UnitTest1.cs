using System;
using HW9;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HW9_Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceTest()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 0);
            double expected = 1;
            double result = p1.Distance(p2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ToStringTest()
        {
            Point p = new Point(0, 0);
            string expected = "\"(0,0)\"";
            string result = p.ToString();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void PerimeterTest()
        {
            Triangle tr1 = new Triangle(
                new Point(10, 20),
                new Point(20, 30),
                new Point(30, 10));
            double expected = 58;
            double result = tr1.Perimeter();
            Assert.AreEqual(expected, result);
        }
    }
}
