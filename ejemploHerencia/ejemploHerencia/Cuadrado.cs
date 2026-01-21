using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    internal class Cuadrado : Figura
    {
        private double posX;
        private double posY;
        private double lado;
        private double otroLado;

        public Cuadrado(double pPosX, double pPosY, double pLado, double pOtroLado) : base(pPosX, pPosY)
        {
            posX = pPosX;
            posY = pPosY;
            lado = pLado;
            otroLado = pOtroLado;
        }

        public double darLado()
        {
            return lado;
        }
        public void cambiarLado(double pLado)
        {
            this.lado = pLado;
        }

        public double darOtrolado()
        {
            return otroLado;
        }
        public void cambiarOtrolado(double pOtroLado)
        {
            this.lado = pOtroLado;
        }




        public override double CalcularArea()
        {
            return this.lado * this.otroLado;
        }



       


    }
}
