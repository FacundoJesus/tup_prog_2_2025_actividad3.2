using P2Ejercicio2.Models;
using System.Collections;

namespace P2Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerAltaPersona_Click(object sender, EventArgs e)
        {
            ArrayList listaPersonas = new ArrayList();

            Persona persona1 = new Persona("Facundo", 40158729);
            Persona persona2 = new Persona("Fausto", 41252365);
            Persona persona3 = new Persona("Ana", 32568742);

            listaPersonas.Add(persona1);
            listaPersonas.Add(persona2);
            listaPersonas.Add(persona3);

            //------------------------

            FDatos fDatos = new FDatos();

            listaPersonas.Sort();
            int dniABuscar = Convert.ToInt32(tbDniABuscar.Text);
            Persona persona = new Persona("", dniABuscar);
            int idx = listaPersonas.BinarySearch(persona);

            if (idx >= 0)
            {
                persona = listaPersonas[idx] as Persona;
                lsbResultado.Items.Add(persona);
                MessageBox.Show("Persona encontrada!");
            }
            else
            {
                MessageBox.Show("Persona no encontrada!");
                fDatos.tbDni.Enabled = false;
                fDatos.lbDni.Enabled = false;
                fDatos.tbDni.Text = Convert.ToString(dniABuscar);
                if (fDatos.ShowDialog() == DialogResult.OK)
                {
                    persona.Dni = Convert.ToInt32(tbDniABuscar.Text);
                    persona.Nombre = fDatos.tbNombre.Text;

                    listaPersonas.Add(new Persona(persona.Nombre, persona.Dni));
                    lsbResultado.Items.Add(persona);
                }
                else
                {
                    MessageBox.Show("Cancelada la operacion al Agregar Persona");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
