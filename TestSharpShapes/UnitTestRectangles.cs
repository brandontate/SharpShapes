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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleContructorSanityRequiresValues()
        {
            Rectangle rectangle = new Rectangle();

        }
    }
}
