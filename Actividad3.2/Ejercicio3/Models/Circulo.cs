using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Circulo: IFigura, IComparable
    {
        public double Radio { get; private set; }

        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Radio;
        }

        //Comparo Áreas CIRCULO
        public int CompareTo(object obj)
        {
            IFigura nuevaFigura = obj as IFigura;
            if(nuevaFigura != null)
            {
                return this.CalcularArea().CompareTo(nuevaFigura.CalcularArea());
            }
            return 1;
        }

        public override string ToString()
        {
            return $"Círculo - Área: {CalcularArea():f2} - Perímetro: {CalcularPerimetro():f2}";
        }
    }
}
