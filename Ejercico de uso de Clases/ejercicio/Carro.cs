using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Carro
    {
        private string marca;
        private string color;
        private int modelo;


        public Carro(string pMarca, string pColor, int pModelo)
        {
            this.marca = pMarca;
            this.color = pColor;
            this.modelo = pModelo;

        }

        //get
        public string darMarca()

        {
            return this.marca;
        }

        // set
        public void cambiarMarca(string pMarca)
        {
            this.marca = pMarca;
        }

        public string darColor()
        {
            return this.color;

        }
        public void cambiarColor(string pColor)
        {
            this.color = pColor;
        }   
            
        public int darModelo()
        {
            return this.modelo;

        }
        public void cambiarModelo(int pModelo)
        {
            this.modelo = pModelo;
        }

        public string informacion()
        {
            return "Soy un carro " + this.marca+ ", modelo" + this.modelo + ", color " + this.color;
        }

    }
}
