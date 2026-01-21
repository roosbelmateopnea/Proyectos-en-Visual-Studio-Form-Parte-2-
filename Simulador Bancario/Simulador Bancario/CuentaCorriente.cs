using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Bancario
{

    internal class CuentaCorriente
    {

        private decimal saldoCorriente;

        private decimal interesmensualCorriente = 0.004m;

        private const decimal IMPUESTO_CORRIENTE = 0.004m;

        public CuentaCorriente(decimal pSaldocorriente)
        {

            this.saldoCorriente = pSaldocorriente;

        }


        public decimal darSaldo()
        {
            return this.saldoCorriente;
        }

        public void cambiarSaldo(decimal pSaldocorriente)
        {
            this.saldoCorriente = pSaldocorriente;
        }



        public void depositar(decimal montoCorriente)
        {
            decimal impuestoDepositar = montoCorriente * IMPUESTO_CORRIENTE;
            this.saldoCorriente += montoCorriente - impuestoDepositar;

            MessageBox.Show($"Consignación exitosa de: {montoCorriente:F2}\nImpuesto descontado: {impuestoDepositar:F2}");
        }




        public void retirar(decimal montoCorriente)
        {
            decimal impuestoRetirar = montoCorriente * IMPUESTO_CORRIENTE;
            decimal totalRetirocCorriente = montoCorriente + impuestoRetirar;


            if (totalRetirocCorriente <= this.saldoCorriente)
            {
                this.saldoCorriente -= totalRetirocCorriente;
                MessageBox.Show($"Retiro exitoso de: {montoCorriente:F2}\nImpuesto descontado: {impuestoRetirar:F2}");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente en la cuenta corriente.");
            }
        }


        public decimal impuestoTransaccionCorriente(decimal montoCorriente)
        {
            return montoCorriente * IMPUESTO_CORRIENTE;
        }
    }



}