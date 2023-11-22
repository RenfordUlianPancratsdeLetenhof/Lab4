using System.Net.NetworkInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4_tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void Circle_Resize_ShouldIncreaseRadius()
        {
            Circle circle = new Circle(10, 20, "Red", 5);
            circle.Resize(2);
            Assert.AreEqual(10, circle.X);
            Assert.AreEqual(20, circle.Y);
            Assert.AreEqual(10, circle.Radius);
            Assert.AreEqual("Red", circle.Color);
        }

        [TestMethod]
        public void Ellipse_Resize_ShouldIncreaseAxes()
        {
            Ellipse ellipse = new Ellipse(30, 40, "Blue", 8, 5);
            ellipse.Resize(3);
            Assert.AreEqual(30, ellipse.X);
            Assert.AreEqual(40, ellipse.Y);
            Assert.AreEqual(24, ellipse.MajorAxis);
            Assert.AreEqual(15, ellipse.MinorAxis);
            Assert.AreEqual("Blue", ellipse.Color);
        }

        [TestMethod]
        public void Ring_Resize_ShouldIncreaseRadiusAndInnerRadius()
        {
            Ring ring = new Ring(50, 60, "Green", 10, 7);
            ring.Resize(2);
            Assert.AreEqual(50, ring.X);
            Assert.AreEqual(60, ring.Y);
            Assert.AreEqual(20, ring.Radius);
            Assert.AreEqual(14, ring.InnerRadius);
            Assert.AreEqual("Green", ring.Color);
        }
    }
}




