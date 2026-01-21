using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploHerencia
{
    internal class Circulo : Figura
    {
        private double posX;
        private double posY;
        private double radio;

        private const double Pi = 3.14;

        public Circulo(double pPosX, double pPosY, double pRadio) : base(pPosX, pPosY)
        {
            posX = pPosX;
            posY = pPosY;
            radio = pRadio;
        }


        public double darRadio()
        {
            return radio;
        }
        public void cambiarRadio(double pRadio)
        {
            this.radio = pRadio;
        }





        public override double CalcularArea()
        {

            return Pi * radio * radio;
        }
    }
}
