using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestRectangles
    {
        [TestMethod]
        public void TestRectangleConstructor()
        {
            Rectangle rectangle = new Rectangle(40, 50);
            Assert.AreEqual(40, rectangle.Width);
            Assert.AreEqual(50, rectangle.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleContructorSanityChecksWidth()
        {
            Rectangle rectangle = new Rectangle(0, 50);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleContructorSanityChecksHeight()
        {
            Rectangle rectangle = new Rectangle(50, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleContructorSanityChecksHeightPositivity()
        {
            Rectangle rectangle = new Rectangle(50, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleContructorSanityChecksWidthPositivity()
        {
            Rectangle rectangle = new Rectangle(-1, 50);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestRectangleContructorSanityRequiresValues()
        //{
        //    Rectangle rectangle = new Rectangle();

        //}

        [TestMethod]
        public void TestScaleRectangle200Percent()
        {
            Rectangle rectangle = new Rectangle(10, 15);
            rectangle.Scale(200);
            Assert.AreEqual(20, rectangle.Width);
            Assert.AreEqual(30, rectangle.Height);
        }

        [TestMethod]
        public void TestScaleRectangle150Percent()
        {
            Rectangle rectangle = new Rectangle(10, 15);
            rectangle.Scale(150);
            Assert.AreEqual(15, rectangle.Width);
            Assert.AreEqual(22.5, rectangle.Height);
        }

        [TestMethod]
        public void TestScaleRectangle100Percent()
        {
            Rectangle rectangle = new Rectangle(10, 15);
            rectangle.Scale(100);
            Assert.AreEqual(10, rectangle.Width);
            Assert.AreEqual(15, rectangle.Height);
        }

        [TestMethod]
        public void TestScaleRectangle37Percent()
        {
            Rectangle rectangle = new Rectangle(10, 15);
            rectangle.Scale(37);
            Assert.AreEqual(3.7, rectangle.Width);
            Assert.AreEqual(4.85, rectangle.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleRectangle0Percent()
        {
            Rectangle rectangle = new Rectangle(10, 15);
            rectangle.Scale(0);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleRectangleNegative5Percent()
        {
            Rectangle rectangle = new Rectangle(10, 15);
            rectangle.Scale(-5);
        }

        [TestMethod]
        public void TestSidesCount()
        {
            Rectangle rectangle = new Rectangle(1, 5);
            Assert.Equals(4, rectangle.SidesCount);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            Rectangle rectangle = new Rectangle(1, 5);
            Assert.Equals(12, rectangle.Perimeter());
        }

        [TestMethod]
        public void TestBiggerRectanglePerimeter()
        {
            Rectangle rectangle = new Rectangle(10, 100);
            Assert.Equals(220, rectangle.Perimeter());
        }

        [TestMethod]
        public void TestRectangleArea()
        {
            Rectangle rectangle = new Rectangle(1, 5);
            Assert.Equals(4, rectangle.Area());
        }

        [TestMethod]
        public void TestBiggerRectangleArea()
        {
            Rectangle rectangle = new Rectangle(10, 100);
            Assert.Equals(1000, rectangle.Area());
        }

        [TestMethod]
        public void TestDefaultRectangleColors()
        {
            Rectangle shape = new Rectangle(10, 15);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
        }
    }
}
