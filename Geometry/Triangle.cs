using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Figure
    {

        public double FirstSide { get;}
        public double SecondSide { get; }
        public double ThridSide { get; }

        private readonly Lazy<bool> _isRightAngled;
        public bool IsRightAnglde => _isRightAngled.Value;
        
        /// <summary>
        /// треугольник
        /// </summary>
        /// <param name="firstSide">первая сторона</param>
        /// <param name="secondSide">вторая сторона</param>
        /// <param name="thridSide">третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Сторона имеет отрицательное значение</exception>
        public Triangle(double firstSide, double secondSide, double thridSide)
        {
            if (firstSide < 0 || secondSide < 0 || thridSide < 0)
            {
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThridSide = thridSide;

            _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
        }
        
        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        protected override double GetSquare()
        {
            // формула герона
            var semiPerimetr = (FirstSide + SecondSide + ThridSide) / 2;

            var firstCoef = semiPerimetr - FirstSide;
            var secondCoef = semiPerimetr - SecondSide;
            var thridCoef = semiPerimetr - ThridSide;

            return Math.Sqrt(semiPerimetr * firstCoef * secondCoef * thridCoef);
        }


        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightAngled()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThridSide }.Max();
            var maxSideSqr = Math.Pow(maxSide, 2);

            return maxSideSqr + maxSideSqr == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) + Math.Pow(ThridSide, 2);
        }
    }
}
