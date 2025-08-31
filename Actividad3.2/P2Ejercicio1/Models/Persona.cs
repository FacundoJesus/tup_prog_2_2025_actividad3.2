using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Ejercicio1.Models
{
    public class Persona : IComparable
    {
        public string Nombre { get; private set; }
        public int Dni { get; private set; }

        public Persona (string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        //Compararlos por DNI
        public int CompareTo(object obj)
        {
            Persona nuevaPersona = obj as Persona;
            if (nuevaPersona != null) {
                return this.Dni.CompareTo(nuevaPersona.Dni);
            }
            return 1;
        }

        public override string ToString()
        {
            return $"{this.Nombre}  -   {this.Dni}";
        }
    }
}
