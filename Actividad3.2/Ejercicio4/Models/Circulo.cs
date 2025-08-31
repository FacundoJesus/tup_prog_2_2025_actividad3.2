using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class Circulo:Figura
    {
        public double Radio {  get; private set; }

        public Circulo(double radio) {
            this.Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio,2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Radio;
        }

        public override string ToString()
        {
            return $"Círculo     -       {CalcularArea():f2}     -     {CalcularPerimetro():f2}";
        }
    }
}
