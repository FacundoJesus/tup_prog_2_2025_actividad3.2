using P2Ejercicio1.Models;
using System.Collections;

namespace P2Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona persona;
        ArrayList listaPersonas = new ArrayList();
        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona("Facundo", 40158729);
            Persona persona2 = new Persona("Jorge", 37825923);
            Persona persona3 = new Persona("Sofia", 35812365);
            Persona persona4 = new Persona("Ana", 42526321);
            Persona persona5 = new Persona("Gerardo", 40123579);

            listaPersonas.Add(persona1);
            listaPersonas.Add(persona2);
            listaPersonas.Add(persona3);
            listaPersonas.Add(persona4);
            listaPersonas.Add(persona5);

            lsbResultado.Items.Clear();
            lsbResultado.Items.Add("Lista no ordenada:");
            lsbResultado.Items.Add("Nombre      DNI");
            foreach (Persona persona in listaPersonas)
            {
                lsbResultado.Items.Add(persona);
            }

            lsbResultado.Items.Add("");

            listaPersonas.Sort();
            lsbResultado.Items.Add("Lista Odenada por DNI:");
            lsbResultado.Items.Add("Nombre      DNI");
            foreach (Persona persona in listaPersonas)
            {
                lsbResultado.Items.Add(persona);
            }


            lsbResultado.Items.Add("");

            //CASO 1: Busco Persona con DNI que no existe...
            int dniBuscado = 45256321;
            Persona personaBuscada1 = new Persona("",dniBuscado);
            int idx = listaPersonas.BinarySearch(personaBuscada1);

            lsbResultado.Items.Add($"Buscando persona con DNI: {dniBuscado}");
            if (idx >= 0)
            {
                Persona personaEncontrada = listaPersonas[idx] as Persona;
                lsbResultado.Items.Add($"Persona encontrada: {personaEncontrada}");
            }
            else
            {
                lsbResultado.Items.Add($"Persona no encontrada.");
            }

            lsbResultado.Items.Add("");

            //CASO 2: Busco Persona con DNI que sí existe...
            int dniBuscado2 = 40158729;
            Persona personaBuscada2 = new Persona("", dniBuscado2);
            int idx2 = listaPersonas.BinarySearch(personaBuscada2);
            lsbResultado.Items.Add($"Buscando persona con DNI: {dniBuscado2}");
            if (idx2 >= 0)
            {
                Persona personaEncontrada2 = listaPersonas[idx2] as Persona;
                lsbResultado.Items.Add($"Persona encontrada: {personaEncontrada2}");
            }
            else
            {
                lsbResultado.Items.Add($"Persona no encontrada.");
            }

        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
