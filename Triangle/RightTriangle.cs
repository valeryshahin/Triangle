using System;

namespace TriangleLibrary
{
    public class RightTriangle: Triangle
    {
        private int legFirst;
        private int legSecond;
        private int hypotenuse;
        public RightTriangle(int legFirst, int legSecond, int hypotenuse)
            : base(legFirst, legSecond, hypotenuse)
        {
            this.legFirst = legFirst;
            this.legSecond = legSecond;
            this.hypotenuse = hypotenuse;

            Init();
        }
        public int LegFirst
        {
            get
            {
                return this.legFirst;
            }
        }
        public int LegSecond
        {
            get 
            {
                return this.legSecond;
            }
        }
        public int Hypotenuse
        {
            get
            {
                return this.hypotenuse;
            }
        }

        private bool Init()
        {
            if (Math.Pow(this.hypotenuse, 2) != Math.Pow(this.legFirst, 2) + Math.Pow(this.legSecond, 2))
            {
                throw new ArgumentException("Данный треугольник не является прямоугольным треугольником!!!");
            }

            return true;
        }
        public override double Area()
        {
            return 0.5 * this.legFirst * this.legSecond;
        }
    }
}
