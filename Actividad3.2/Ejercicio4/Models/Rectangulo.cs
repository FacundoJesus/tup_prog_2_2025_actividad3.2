using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class Rectangulo:Figura
    {
        public double Lado { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double lado, double ancho) {
            this.Lado = lado;
            this.Ancho = ancho;
        }

        public override double CalcularArea()
        {
            return this.Lado * this.Ancho;
        }

        public override double CalcularPerimetro()
        {
            return (this.Lado + this.Ancho) * 2;
        }

        public override string ToString()
        {
            return $"Rectangulo     -       {CalcularArea():f2}     -     {CalcularPerimetro():f2}";
        }
    }
}
