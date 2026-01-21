using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploHerencia
{
    public partial class Form1 : Form
    {


        public Form1()


           
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var primerLado = double.Parse(txtCuadradoLado.Text);
            var segundoLado = double.Parse(txtCuadradoSLado.Text);

           

            Cuadrado cuadrado = new Cuadrado(0, 0, primerLado,segundoLado);


            lblResultadoCuadrado.Text = cuadrado.CalcularArea().ToString();                                                                                                                        

         
          

        }

        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
            var radio = double.Parse(txtCirculoRadio.Text);
           



            Circulo circulo = new Circulo(0, 0, radio);


            lblResultadoCirculo.Text = circulo.CalcularArea().ToString();
        }
    }
}
