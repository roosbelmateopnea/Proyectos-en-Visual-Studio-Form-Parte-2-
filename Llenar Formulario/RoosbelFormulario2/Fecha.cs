using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andreaFormulario2
{
    internal class Fecha
    {
        private int dia;
        private int mes;
        private int annio;

        //Set
        public Fecha(int pDia, int pMes, int pAnnio)
        {

            this.dia = pDia;
            this.mes = pMes;
            this.annio = pAnnio;


        }
        public Fecha()
        {
            // Get
            DateTime hoy = DateTime.Now;
            this.dia = hoy.Day;
            this.mes = hoy.Month;
            this.annio = hoy.Year;
        }



        // Get
        public int getDia()
        {
            return this.dia;

        }


        // Set
        public void setDia(int pDia)
        {
            this.dia = pDia;

        }



        // Get
        public int getMes()
        {
            return this.mes;

        }


        // Set
        public void setMes(int pMes)
        {
            this.mes = pMes;

        }

        // Get
        public int getAnnio()
        {
            return this.annio;

        }

        // Set
        public void setAnnio(int pAnnio)
        {
            this.annio = pAnnio;


        }


        public int DiferenciaFechaMeses(Fecha pFecha)
        {

            //calcular edad  y antiguedad

            DateTime hoy = DateTime.Now;
            DateTime fechaParametro = new DateTime(this.annio, this.mes, this.dia);
            int diferenciaMeses = (hoy.Year - fechaParametro.Year) * 12 + (hoy.Month - fechaParametro.Month);

            return diferenciaMeses;



        }

        public string toStringb()
        {
            return this.dia + "/" + this.mes + "/" + this.annio;
        }

    }
}
