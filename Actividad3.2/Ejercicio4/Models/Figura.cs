using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public abstract class Figura : IFigura, IComparable
    {
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public int CompareTo(object obj)
        {
            IFigura nuevaFigura = obj as IFigura;
            if (nuevaFigura != null)
            {
                return this.CalcularArea().CompareTo(nuevaFigura.CalcularArea());
            }
            return 1;
        }
    }
}
