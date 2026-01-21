using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Bancario
{
    internal class CDT
    {
        private decimal valorInvertido;
        private decimal interesMensualcdt = 0.006m;
        private Mes mesApertura;


        // Constructor
        public CDT(int pValorinvertido, int pInteresmensualcdt)
        {
            this.valorInvertido = pValorinvertido;
            this.interesMensualcdt = pInteresmensualcdt;
         
        }

 
        public decimal darValorinvertido()
        {
            return this.valorInvertido;
        }

        public void cambiarValorinvertido(decimal pValorinvertido)
        {
            this.valorInvertido = pValorinvertido;
        }


        public decimal darInteresmensual()
        {
            return this.interesMensualcdt;
        }

        public void cambiarInteresMensual(decimal pInteresmensual)
        {
            this.interesMensualcdt = pInteresmensual;
        }



        public void Invertir(decimal valorcdt, decimal interesCdt, int numeroMes)
        {
            valorInvertido = valorcdt;
            interesMensualcdt = interesCdt;
            mesApertura = new Mes(numeroMes);
        }




        public decimal ValorPresente(Mes mesActual)
        {
            if (mesApertura == null)
            {
                throw new InvalidOperationException("El CDT no tiene mes de apertura definido.");
            }

            int mesesTranscurridos = mesActual.DiferenciaMeses(mesApertura);
            return valorInvertido + (mesesTranscurridos * interesMensualcdt * valorInvertido);
        }



        public decimal Cerrar(Mes mesActual)
        {
            decimal valorCierre = ValorPresente(mesActual);
            valorInvertido = 0.0M;
            interesMensualcdt = 0.0M;
            mesApertura = null;
            return valorCierre;
        }


    }
}
