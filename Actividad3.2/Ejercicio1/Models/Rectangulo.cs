using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Rectangulo : IFigura,IComparable
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double largo, double ancho) {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public double CalcularArea()
        {
            return this.Largo * this.Ancho;
        }

        public double CalcularPerimetro()
        {
            return (2 * this.Largo) + (2 * this.Ancho);
        }

        //Comparo áreas
        public int CompareTo(object obj)
        {
            Rectangulo otroRectangulo = obj as Rectangulo;
            if (otroRectangulo != null)
            {
                CalcularArea().CompareTo(otroRectangulo.CalcularArea());
            }
            return 1;
        }

        public override string ToString()
        {
            return $"Rectángulo - Área: {CalcularArea():f2} - Perímetro: {CalcularPerimetro():f2}";
        }
    }
}
