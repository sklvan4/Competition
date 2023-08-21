namespace Trigonometry.Core
{
    public static class Square
    {
        public static double CalcTriangle(double side1, double side2, double side3, int precision = 2)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0 || precision <= 0)
                return 0;
            if(!Base.IsTriangle(side1, side2, side3))
                throw new ArgumentException("Given args aren't triangle parts");
            //Let's say, we have much faster right triangle square method or equilateral than Heron's cuz sqrt,
            //then we'd prefer to check and switch method if so
            double result = 0;
            if (Base.IsRightTriangle(side1, side2, side3))
                result = CalcRightTriangle(side1, side2, side3);
            else if (Base.IsEquilateralTriangle(side1, side2, side3))
                result = CalcEquilateralTriangle(side1);
            else
                result = CalcHeronMethod(side1, side2, side3);
            return Math.Round(result, precision);
        }

        public static double CalcCircle(double radius, int precision = 2)
        {
            if(radius <= 0 || precision <= 0)
                return 0;
            return Math.Round(Math.PI * Math.Pow(radius, 2), precision);
        }

        static double CalcHeronMethod(double side1, double side2, double side3)
        {
            var halfPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        }

        static double CalcRightTriangle(double side1, double side2, double side3)
        {
            double catethus1 = side1, catethus2 = side2, hypotenuse = side3;
            if (catethus1 > hypotenuse)
            {
                catethus1 = hypotenuse;
                hypotenuse = side1;
            }
            if (catethus2 > hypotenuse)
                catethus2 = hypotenuse;
            return catethus1 * catethus2 / 2;
        }

        static double CalcEquilateralTriangle(double side)
        {
            return Math.Sqrt(3) * Math.Pow(side, 2) / 4;
        }
    }
}