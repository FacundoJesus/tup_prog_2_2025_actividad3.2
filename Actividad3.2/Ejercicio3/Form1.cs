using Ejercicio3.Models;
using System.Collections;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            ArrayList listaFiguras = new ArrayList();

            IFigura cuadrado1 = new Cuadrado(3);
            IFigura circulo1 = new Circulo(3);
            IFigura rectangulo1 = new Rectangulo(3, 2);
            IFigura rectangulo2 = new Rectangulo(6, 3);
            IFigura circulo2 = new Circulo(6);
            
            listaFiguras.Add(rectangulo1);
            listaFiguras.Add(rectangulo2);
            listaFiguras.Add(circulo1);
            listaFiguras.Add(circulo2);
            listaFiguras.Add(cuadrado1);

            lsbResultado.Items.Add("Lista sin ordenar:");
            foreach (IFigura f in listaFiguras)
            {
                lsbResultado.Items.Add(f);
            }
            
            lsbResultado.Items.Add("---");

            listaFiguras.Sort();
            lsbResultado.Items.Add("Lista de figuras ordenadas por Área:");
            foreach(IFigura f in listaFiguras)
            {
                lsbResultado.Items.Add(f);
            }

        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
