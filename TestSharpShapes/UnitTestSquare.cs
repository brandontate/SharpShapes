using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(40);
            Assert.AreEqual(40, square.Width);
            Assert.AreEqual(40, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorZeroCheck()
        {
            Square square = new Square(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorNegativeCheck()
        {
            Square square = new Square(-5);
        }

        [TestMethod]
        public void TestSquareScale200Percent()
        {
            Square square = new Square(10);
            square.Scale(200);
            Assert.AreEqual(20, square.Width);
            Assert.AreEqual(20, square.Height);
        }

        [TestMethod]
        public void TestSquareScale150Percent()
        {
            Square square = new Square(10);
            square.Scale(150);
            Assert.AreEqual(15, square.Width);
            Assert.AreEqual(15, square.Height);
        }

        [TestMethod]
        public void TestSquareScale100Percent()
        {
            Square square = new Square(10);
            square.Scale(100);
            Assert.AreEqual(10, square.Width);
            Assert.AreEqual(10, square.Height);
        }

        [TestMethod]
        public void TestSquareScale37Percent()
        {
            Square square = new Square(50);
            square.Scale(37);
            Assert.AreEqual((decimal) 18.5, square.Width);
            Assert.AreEqual((decimal) 18.5, square.Height);
        }

        [TestMethod]
        public void TestSquareUpAndDown()
        {
            Square square = new Square(40);
            square.Scale(50);
            square.Scale(200);
            Assert.AreEqual(40, square.Width);
            Assert.AreEqual(40, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareScale0Percent()
        {
            Square square = new Square(50);
            square.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareScaleNegativePercent()
        {
            Square square = new Square(50);
            square.Scale(-9);
        }

        [TestMethod]
        public void TestSquareSideCount()
        {
            Square square = new Square(50);
            Assert.AreEqual(4, square.SidesCount);
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(50);
            Assert.AreEqual(200, square.Perimeter());
        }

        [TestMethod]
        public void TestBiggerSquarePerimeter()
        {
            Square square = new Square(100);
            Assert.AreEqual(400, square.Perimeter());
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(50);
            Assert.AreEqual(2500, square.Area());
        }

        [TestMethod]
        public void TestBiggerSquareArea()
        {
            Square square = new Square(100);
            Assert.AreEqual(10000, square.Area());
        }

        [TestMethod]
        public void TestDefaultSquareColors()
        {
            Square rectangle = new Square(50);
            Assert.AreEqual(System.Drawing.Color.Tomato, rectangle.BorderColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, rectangle.FillColor);
        }

    }
}
