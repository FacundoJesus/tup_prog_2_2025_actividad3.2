using Ejercicio4.Models;
using System.Collections;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList listaFiguras = new ArrayList();
        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            IFigura rectangulo1 = new Rectangulo(3, 2);
            IFigura rectangulo2 = new Rectangulo(6, 4);
            IFigura rectangulo3 = new Rectangulo(8, 3);
            IFigura rectangulo4 = new Rectangulo(2, 1);
            IFigura rectangulo5 = new Rectangulo(9, 2);
            IFigura circulo1 = new Circulo(5);
            IFigura circulo2 = new Circulo(2);
            IFigura circulo3 = new Circulo(1);
            IFigura circulo4 = new Circulo(6);
            IFigura cuadrado1 = new Cuadrado(2);
            IFigura cuadrado2 = new Cuadrado(1);
            IFigura cuadrado3 = new Cuadrado(5);
            IFigura cuadrado4 = new Cuadrado(4);

            listaFiguras.Add(rectangulo1);
            listaFiguras.Add(rectangulo2);
            listaFiguras.Add(rectangulo3);
            listaFiguras.Add(rectangulo4);
            listaFiguras.Add(rectangulo5);
            listaFiguras.Add(circulo1);
            listaFiguras.Add(circulo2);
            listaFiguras.Add(circulo3);
            listaFiguras.Add(circulo4);
            listaFiguras.Add(cuadrado1);
            listaFiguras.Add(cuadrado2);
            listaFiguras.Add(cuadrado3);
            listaFiguras.Add(cuadrado4);

            lsbResultado.Items.Clear();
            lsbResultado.Items.Add("Lista no ordenada:");
            lsbResultado.Items.Add("Figura      Area        Perimetro");
            foreach (IFigura figura in listaFiguras)
            {
                lsbResultado.Items.Add(figura);
            }

            listaFiguras.Sort();
            lsbResultado.Items.Add("Lista Ordenada por Área:");
            lsbResultado.Items.Add("Figura      Area        Perimetro");
            foreach (IFigura figura in listaFiguras)
            {
                lsbResultado.Items.Add(figura);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
