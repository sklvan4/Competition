using NUnit.Framework;
using Trigonometry.Core;

namespace Trigonometry.Tests.Core
{
    [TestFixture]
    public class BaseTests
    {
        [Test]
        public void IsRightTriangle_Test()
        {
            double side1 = 3, side2 = 4, side3 = 5;
            var result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsTrue(result);
            side1 = 3; side2 = 5; side3 = 4;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsTrue(result);
            side1 = 4; side2 = 3; side3 = 5;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsTrue(result);
            side1 = 4; side2 = 5; side3 = 3;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsTrue(result);
            side1 = 5; side2 = 3; side3 = 4;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsTrue(result);
            side1 = 5; side2 = 4; side3 = 3;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsTrue(result);

            side1 = 3.1;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsFalse(result);

            side1 = 3; side2 = 4; side3 = -5;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsFalse(result);

            side1 = 0; side2 = 0; side3 = 0;
            result = Base.IsRightTriangle(side1, side2, side3);
            Assert.IsFalse(result);
        }
    }
}
