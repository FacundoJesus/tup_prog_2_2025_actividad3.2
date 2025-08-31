using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Cuadrado:Rectangulo
    {
        public Cuadrado(double lado):base(lado,lado) { }

        
        public override string ToString()
        {
            return $"Cuadrado - Área: {CalcularArea():f2} - Perímetro: {CalcularPerimetro():f2}";
        }
        

        


    }
}
