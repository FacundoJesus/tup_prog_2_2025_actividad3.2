using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Figura rectangulo1 = new Rectangulo(3, 2);
        Figura cuadrado1 = new Cuadrado(2, 2);
        Figura circulo1 = new Circulo(2);

        private void btnVer_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();

            lsbResultado.Items.Add(rectangulo1.ToString());
            lsbResultado.Items.Add(cuadrado1.ToString());
            lsbResultado.Items.Add(circulo1.ToString());
        }
    }
}
