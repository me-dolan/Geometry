using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Figure
    {
        public double Radius { get; }
        
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Радиус круга имеет отрицительное значение</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("радиус не может быть отрицательным");
            }

            Radius = radius;
        }
       

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        /// <returns></returns>
        protected override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
