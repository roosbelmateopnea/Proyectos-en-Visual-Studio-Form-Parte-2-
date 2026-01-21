using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Bancario
{
    internal class Mes
    {
        private int mes;
        private int anio;

        // Consttructor 1
        public Mes(int pMes, int pAnio)
        {
            this.mes = pMes;
            this.anio = pAnio;
        }


        public Mes(int pMes)
        {
            this.mes = pMes;
            this.anio = DateTime.Now.Year;
        }


        public int darMes()
        {
            return this.mes;
        }




        public void cambiarNumeroMes(int pMes)
        {
            this.mes = pMes;
        }

        public int darAnio()
        {
            return this.anio;
        }
        public void cambiarAnio(int pAnio)
        {
            this.anio = pAnio;
        }




        public void AvanzarMes()
        {
            this.mes++;
            if (this.mes > 12)
            {
                this.mes = 1;
                this.anio++;
            }

        }

        public int DiferenciaMeses(Mes otroMes)
        {
            int diferenciaAnio = this.anio - otroMes.anio;
            int diferenciaMes = this.mes - otroMes.mes;
            return (diferenciaAnio * 12) + diferenciaMes;
        }


    }

}
