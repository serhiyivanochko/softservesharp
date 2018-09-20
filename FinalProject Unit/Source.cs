using System;
using NUnit.Framework;
using FinalProject;
using System.IO;
using System.Collections.Generic;

namespace FinalProject_Unit
{
    [TestFixture]
    public class TestFruit
    {
        [TestCase("Orange","Orange")]
        [TestCase("Lemon", "Yellow")]
        public void FruitInitialize(string name, string color)
        {
            Fruit fruit = new Fruit(name,color);

            Assert.AreEqual(fruit.Name, name);
            Assert.AreEqual(fruit.Color, color);
        }

        [TestCase("Apple","green")]
        public void InputFromFile(string name, string color)
        {

            StreamReader sr = new StreamReader(GlobalConst.FileDirectory+GlobalConst.FruitFile);
            Fruit fruit = new Fruit();

            try
            {
                fruit.Input(sr.ReadLine().Split(' '));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                sr.Close();
            }
            
            Assert.AreEqual(fruit.Name, name);
            Assert.AreEqual(fruit.Color, color);
        }

        [TestCase("Orange", "Orange")]
        [TestCase("Lemon", "Yellow")]
        public void ToStringFruit(string name, string color)
        {
            Fruit fruit = new Fruit(name,color);

            string actual = fruit.ToString();
            string expected = $"Fruit: {name}, fruit color: {color}";

            Assert.AreEqual(actual, expected);
        }
    }

    [TestFixture]
    public class TestCitrus
    {
        [TestCase("Orange", "Orange", 5.5)]
        [TestCase("Lemon", "Yellow", 2.3)]
        public void CitrusInitialize(string name, string color, double vitamin_c)
        {
            Citrus citrus = new Citrus(name,color,vitamin_c);

            Assert.AreEqual(citrus.Name, name);
            Assert.AreEqual(citrus.Color, color);
            Assert.AreEqual(citrus.Vitamin_c, vitamin_c);
        }
        [TestCase("Orange","orange",3.2)]
        public void CitrusInputFromFile(string name, string color, double vitamin_c) {

            StreamReader sr = new StreamReader(GlobalConst.FileDirectory + GlobalConst.FruitFile);
            Citrus citrus = new Citrus();

            try
            {
                string[] current = new string[3];
                for (int i = 0; i < 2; i++) {
                    current = sr.ReadLine().Split(' ');
                }
                citrus.Input(current);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }

            Assert.AreEqual(citrus.Name, name);
            Assert.AreEqual(citrus.Color, color);
            Assert.AreEqual(citrus.Vitamin_c, vitamin_c);
            
        }
        [TestCase("5.5")]
        [TestCase("5,5")]
        public void ToDoubleConvert(string input) {

            double expected = 5.5;
            double actual = Citrus.ToDouble(input);

            Assert.AreEqual(expected, actual);
        }



        [TestCase("Orange", "Orange", 5.5)]
        [TestCase("Lemon", "Yellow", 2.3)]
        public void ToStringCitrus(string name, string color, double vitamin_c)
        {
            Citrus citrus = new Citrus(name, color,vitamin_c);

            string actual = citrus.ToString();
            string expected = $"Fruit: {name}, fruit color: {color}, vitamine C: {vitamin_c}gr.";

            Assert.AreEqual(actual,expected);
        }
    }

    [TestFixture]
    public class TestMain {

        [Test]
        public void SortTest() {
            List<Fruit> actual = new List<Fruit>();
            actual.Add(new Fruit("Fruit3", "Color"));
            actual.Add(new Fruit("Fruit1", "Color"));
            actual.Add(new Fruit("Fruit2", "Color"));
            actual.Add(new Fruit("Fruit4", "Color"));

            actual = Program.Sort(actual);

            List<Fruit> expected = new List<Fruit>();
            expected.Add(new Fruit("Fruit1", "Color"));
            expected.Add(new Fruit("Fruit2", "Color"));
            expected.Add(new Fruit("Fruit3", "Color"));
            expected.Add(new Fruit("Fruit4", "Color"));


            for (int i = 0; i < actual.Count; i++) {
                Assert.AreEqual(actual[i].Name, expected[i].Name);
            }
        }
        

    }

}
