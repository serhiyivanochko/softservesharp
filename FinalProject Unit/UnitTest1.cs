using System;
using NUnit.Framework;
using FinalProject;

namespace FinalProject_Unit
{
    [TestFixture]
    public class TestFruit
    {
        [Test]
        public void FruitInitialize()
        {
            Fruit fruit = new Fruit("Orange", "Orange");

            Assert.AreEqual(fruit.Name, "Orange");
            Assert.AreEqual(fruit.Color, "Orange");
        }

        [Test]
        public void InputFromFile()
        {
            Fruit fruit = new Fruit();
            fruit.Input(new string[] { "Orange", "Orange" });

            Assert.AreEqual(fruit.Name, "Orange");
            Assert.AreEqual(fruit.Color, "Orange");
        }

        [Test]
        public void ToStringFruit()
        {
            Fruit fruit = new Fruit("Orange", "Orange");

            Assert.AreEqual(fruit.ToString(), "Fruit: Orange, fruit color: Orange");
        }
    }

    [TestFixture]
    public class TestCitrus
    {
        [Test]
        public void CitrusInitialize()
        {
            Citrus citrus = new Citrus("Orange", "Orange", 5.5);

            Assert.AreEqual(citrus.Name, "Orange");
            Assert.AreEqual(citrus.Color, "Orange");
            Assert.AreEqual(citrus.Vitamin_c, 5.5);
        }
        [Test]
        public void CitrusInputFromFile() {
            Citrus citrus = new Citrus();
            citrus.Input(new string[] { "Orange", "Orange","5.5" });

            Assert.AreEqual(citrus.Name, "Orange");
            Assert.AreEqual(citrus.Color, "Orange");
            Assert.AreEqual(citrus.Vitamin_c, 5.5);
        }
        [Test]
        public void ToDoubleConvertWithDot() {
            double expected = 5.5;
            double actual = Citrus.ToDouble("5.5");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ToDoubleConvertWithComa()
        {
            double expected = 5.5;
            double actual = Citrus.ToDouble("5,5");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ToStringCitrus()
        {
            Citrus citrus = new Citrus("Orange", "Orange",5.5);
            string actual = citrus.ToString();
            string expected = "Fruit: Orange, fruit color: Orange, vitamine C: 5,5gr.";
            Assert.AreEqual(actual,expected);
        }
    }
    
}
