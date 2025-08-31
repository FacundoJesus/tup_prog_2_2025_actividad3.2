﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class Cuadrado:Rectangulo
    {
        public double Lado { get; set; }

        public Cuadrado (double lado):base(lado,lado)
        {
            this.Lado = lado;
        }

        public override string ToString()
        {
            return $"Cuadrado     -       {CalcularArea():f2}     -     {CalcularPerimetro():f2}";
        }
    }
}
