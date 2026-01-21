using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraandrea3
{
    public partial class Form1 : Form
    {
        private string ruta;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_3(object sender, EventArgs e)
        { 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = Convert.ToDouble(numericUpDown3.Text);
                double estatura = Convert.ToDouble(numericUpDown4.Text);
                double estM = estatura / 100;
                double imc = estM * estM;
                double imcb = peso / imc;



                if (peso <= 0 || estatura <= 0)
                {
                    MessageBox.Show("Error de Ingreso de Datos");
                }

                else if (peso > 1 && estatura > 1)

                    if (imcb < 18.5)
                    {
                        label9.Text = "Usted sufre de bajo peso.\nSu IMC es: " + imcb.ToString("0.00");
                    }
                    else if (imcb >= 18.5 && imcb < 24.9)
                    {
                        label9.Text = "Tiene peso normal.\nSu IMC es: " + imcb.ToString("0.00");
                    }
                    else if (imcb >= 25 && imcb < 29.9)
                    {
                        label9.Text = "Tiene sobrepeso.\nSu IMC es: " + imcb.ToString("0.00");
                    }
                    else if (imcb >= 29.9)
                    {
                        label9.Text = "Tiene obesidad.\nSu IMC es: " + imcb.ToString("0.00");
                    }
                    else if (peso <= 0 || estatura <= 0)
                    {
                        MessageBox.Show("Error Ingreso de Datos");
                    }

                numericUpDown3.Text = "0";
                numericUpDown4.Text = "0";

            }
            catch
            {
                MessageBox.Show("Error Ingreso de Datos");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown3.Text = "0";
            numericUpDown4.Text = "0";
            label9.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}












