using NUnit.Framework;
using Trigonometry.Core;

namespace Trigonometry.Tests.Core
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void CalcTriangle_Test()
        {
            double side1 = 0, side2 = 1, side3 = 2;
            var square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 0);

            side1 = -1; side2 = 4; side3 = 6;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 0);

            side1 = 3; side2 = 4; side3 = 5;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 6);
            side1 = 3; side2 = 5; side3 = 4;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 6);
            side1 = 4; side2 = 3; side3 = 5;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 6);
            side1 = 4; side2 = 5; side3 = 3;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 6);
            side1 = 5; side2 = 3; side3 = 4;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 6);
            side1 = 5; side2 = 4; side3 = 3;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 6);

            side1 = side2 = side3 = 3.5;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 5.3);

            side1 = 7;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 0);

            side1 = 6.9999999;
            square = Square.CalcTriangle(side1, side2, side3);
            Assert.AreEqual(square, 0);
            square = Square.CalcTriangle(side1, side2, side3, precision: 5);
            Assert.AreEqual(square, 0.00207);

            side1 = 10;
            try
            {
                square = Square.CalcTriangle(side1, side2, side3);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }
        }

        [Test]
        public void CalcSquare_Test()
        {
            double radius = -1;
            var square = Square.CalcCircle(radius);
            Assert.AreEqual(square, 0);

            radius = 0;
            square = Square.CalcCircle(radius);
            Assert.AreEqual(square, 0);

            radius = 2.25;
            square = Square.CalcCircle(radius);
            Assert.AreEqual(square, 15.9);

            radius = 0.01;
            square = Square.CalcCircle(radius);
            Assert.AreEqual(square, 0);
            square = Square.CalcCircle(radius, precision: 5);
            Assert.AreEqual(square, 0.00031);
        }
    }
}
