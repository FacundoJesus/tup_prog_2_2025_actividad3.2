using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Ejercicio2.Models
{
    public class Persona : IComparable
    {
        public string Nombre { get; set; }
        public int Dni {  get; set; }

        public Persona(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        public int CompareTo(object obj)
        {
            Persona nuevaPersona = obj as Persona;
            if(nuevaPersona!=null) {
                return this.Dni.CompareTo(nuevaPersona.Dni);
            }
            return 1;
        }

        public override string ToString() {
            return $"{this.Nombre} - {this.Dni}";
        }
    }
}
