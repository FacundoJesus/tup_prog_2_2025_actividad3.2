using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rectangulo rectangulo1 = new Rectangulo(3, 2);
        Circulo circulo1 = new Circulo(2);
        Cuadrado cuadrado1 = new Cuadrado(2,2);

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();

            IFigura[] figuras = new IFigura[] { rectangulo1, circulo1, cuadrado1 };

            foreach ( IFigura f in figuras)
            {
                lsbResultado.Items.Add(f);
            }
        }
    }
}
