using Assignment12;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{

    [TestClass]
    public class CircleclassTests
    {



        [TestMethod]
        public void Area_Circle_Tests()
        {

            Circleclass circle = new Circleclass()
            {
                radius = 2
            };
            double AreaTestResult = circle.Area;

            Assert.AreEqual(AreaTestResult, 12.56);

        }
        [TestMethod]
        public void Circumferance_Circle_Tests()
        {

            Circleclass circle = new Circleclass()
            {
                radius = 2
            };
            double circumTestResult = circle.Circumference;

            Assert.AreEqual(circumTestResult, 12.56);

        }


    }

    [TestClass]
    public class RectangleclassTests
    {



        [TestMethod]
        public void Area_Reactangle_Tests()
        {

            Rectangleclass rectangle = new Rectangleclass()
            {
                breadth = 3,
                length = 4

            };
            double AreaTestResult = rectangle.Area;

            Assert.AreEqual(AreaTestResult, 12);

        }
        [TestMethod]
        public void Circum_Rectangle_Tests()
        {

            Rectangleclass rectangle = new Rectangleclass()
            {
                breadth = 3,
                length = 4
            };
            double circumTestResult = rectangle.Circumference;

            Assert.AreEqual(circumTestResult, 14);

        }


    }
    [TestClass]
    public class TriangleclassTests
    {



        [TestMethod]
        public void Area_Triangle_Tests()
        {

            Triangleclass Triangle = new Triangleclass()
            {
                triangleBase = 3,
                height = 4

            };
            double AreaTestResult = Triangle.Area;

            Assert.AreEqual(AreaTestResult, 6);

        }
        [TestMethod]
        public void Circum_Triangle_Tests()
        {

            Triangleclass Triangle = new Triangleclass()
            {
                triangleBase = 3,
                leftside = 5,
                rightside = 6,
            };
            double circumTestResult = Triangle.Circumference;

            Assert.AreEqual(circumTestResult, 14);

        }


    }
    [TestClass]
    public class SquareclassTests
    {



        [TestMethod]
        public void Area_Square_Tests()
        {

            Squareclass Square = new Squareclass()
            {
                sides = 4

            };
            double AreaTestResult = Square.Area;

            Assert.AreEqual(AreaTestResult, 16);

        }
        [TestMethod]
        public void Circum_Square_Tests()
        {

            Squareclass Square = new Squareclass()
            {
                sides = 4
            };
            double circumTestResult = Square.Circumference;

            Assert.AreEqual(circumTestResult, 16);

        }


    }
}
