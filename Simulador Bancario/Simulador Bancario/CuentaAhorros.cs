using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Bancario
{
    internal class CuentaAhorros
    {

        private decimal saldoAhorros;
    
        private decimal interesmensualahorros = 0.006m;

        const decimal IMPUESTO_AHORRO = 0.004m;

        public CuentaAhorros(decimal pSaldoahorros, decimal pInteresmensualahorros)
        {
            
            this.saldoAhorros = pSaldoahorros;
            this.interesmensualahorros = pInteresmensualahorros;
        }

  

        public decimal darSaldoAhorros() 
        { 
            return this.saldoAhorros; 
        }
        public void cambiarSaldo(decimal pSaldoahorros) 
        { 
            this.saldoAhorros = pSaldoahorros; 
        }

        public decimal darInteresmensual() 
        { 
            return this.interesmensualahorros; 
        }

        public void cambiarInteres(decimal pInteresmensual) 
        { 
            this.interesmensualahorros = pInteresmensual; 
        }




        public decimal ActualizarSaldoTransicionMes()
        {
            decimal interesahorro = this.saldoAhorros * this.interesmensualahorros;
            this.saldoAhorros += interesahorro;
            return interesahorro; 

        }




        public void depositar(decimal montoAhorros)
        {

            decimal impuestoDepositar = montoAhorros * IMPUESTO_AHORRO;
            this.saldoAhorros += montoAhorros - impuestoDepositar;

            MessageBox.Show($"Consignación exitosa de: {montoAhorros:F2}\nImpuesto descontado: {impuestoDepositar:F2}");




        }



        public void retirar(decimal montoAhorros)
        {
            decimal impuestoRetirar = montoAhorros * IMPUESTO_AHORRO;
            decimal totalRetiroAhorros = montoAhorros + impuestoRetirar;


            if (totalRetiroAhorros <= this.saldoAhorros)
            {
                this.saldoAhorros -= totalRetiroAhorros;
                MessageBox.Show($"Retiro exitoso de: {montoAhorros:F2}\nImpuesto descontado: {impuestoRetirar:F2}");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente en la cuenta corriente.");
            }
        }




        public decimal impuestoTransaccionAhorro(decimal montoAhorros)
        {
            return montoAhorros * IMPUESTO_AHORRO;
        }


        













    }

}


