using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TriangleTest()
        {
            Triangle t = new Triangle(5, 7, 9);
            Assert.AreEqual(t.Perimetr(), 21);

            RightTriangle rt = new RightTriangle(3, 4, 5);
            Assert.AreEqual(rt.Perimetr(), 12);
            Assert.AreEqual(rt.Area(), 6);
        }
    }
}
