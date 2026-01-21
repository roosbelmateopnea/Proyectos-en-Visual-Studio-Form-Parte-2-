using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ejercicio
{
    public partial class Form1 : Form
    {
        Carro carro;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string color = txtColor.Text;
            int modelo = int.Parse(txtModelo.Text);
            carro = new Carro(marca, color, modelo);
           


        }




        private void button2_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = carro.darMarca();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string marcaNueva = txtMarca.Text;

            carro.cambiarMarca(marcaNueva);
            lblInformacion.Text = "Se cambio la marca";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string color = txtColor.Text;
            int modelo = int.Parse(txtModelo.Text);
            carro = new Carro(marca, color, modelo);
            lblInformacion.Text = carro.informacion();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = carro.darColor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string colorNueva = txtColor.Text;
            carro.cambiarColor(colorNueva);
            lblInformacion.Text = "Se cambio el Color";
        


            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            lblInformacion.Text = carro.darModelo().ToString();

           

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int modeloNueva = int.Parse(txtModelo.Text);
            carro.cambiarModelo(modeloNueva);
            lblInformacion.Text = "Se cambió el Modelo";

            
        }
    }
}
