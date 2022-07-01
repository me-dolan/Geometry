using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Figure
    {
        private readonly Lazy<double> _square;

        public double Square => _square.Value;
        protected Figure()
        {
            _square = new Lazy<double>(GetSquare);
        }

        protected abstract double GetSquare();
    }
}
