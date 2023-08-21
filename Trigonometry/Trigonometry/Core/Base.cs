namespace Trigonometry.Core
{
    public static class Base
    {
        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                return false;

            double catethus1 = side1, catethus2 = side2, hypotenuse = side3;
            if (catethus1 > hypotenuse)
            {
                catethus1 = hypotenuse;
                hypotenuse = side1;
            }
            if (catethus2 > hypotenuse)
            {
                catethus2 = hypotenuse;
                hypotenuse = side2;
            }
            return Math.Pow(hypotenuse, 2) == Math.Pow(catethus1, 2) + Math.Pow(catethus2, 2);
        }

        internal static bool IsTriangle(double side1, double side2, double side3)
        {
            return side1 + side2 >= side3
                && side2 + side3 >= side1
                && side1 + side3 >= side2;
        }

        internal static bool IsEquilateralTriangle(double side1, double side2, double side3) =>
            side1 == side2 && side2 == side3;
    }
}