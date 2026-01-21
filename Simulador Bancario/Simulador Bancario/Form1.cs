using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Bancario
{
    public partial class Form1 : Form
    {

        CuentaBancaria cuentabancaria;
        CuentaCorriente cuentacorriente;
        CuentaAhorros cuentaahorros;
        CDT cdt;
        Mes mes;




        public Form1()
        {
            InitializeComponent();
            cuentacorriente = new CuentaCorriente(0); 
            cuentaahorros = new CuentaAhorros(0, 0);

            mes = new Mes(DateTime.Now.Month, DateTime.Now.Year);
            cuentaahorros = new CuentaAhorros(0, 0.006m);
            txtNumeromes.Text = mes.darMes().ToString();

            mes = new Mes(0,0);
            cdt = new CDT(0,0);




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();

            try
            {
                if (txtNombre.Text == "" && txtCedula.Text == "")
                {
                    MessageBox.Show($"Campos de ingreso de datos Vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    
                    cuentabancaria = new CuentaBancaria(cedula, nombre);



                    MessageBox.Show("Datos guardados correctamente.");
                }
            }

            catch
            {
                MessageBox.Show($"Error de ingreso de Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnAumentarnmes_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (string.IsNullOrEmpty(txtNumeromes.Text))
                {
                    MessageBox.Show("Por favor ingrese el número del mes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                


              

                if (cuentaahorros != null && cuentaahorros.darSaldoAhorros() > 0)
                {
                    int numeroMes = int.Parse(txtNumeromes.Text);
                    mes.cambiarNumeroMes(numeroMes);
                    decimal interes = cuentaahorros.ActualizarSaldoTransicionMes();

                    

                    txtSaldoahorros.Text = cuentaahorros.darSaldoAhorros().ToString("F2");
                    txtTotal.Text = (cuentaahorros.darSaldoAhorros() + cuentacorriente.darSaldo()).ToString("F2");

                    MessageBox.Show("Mes ingresado: " + mes.darMes() + "/" + mes.darAnio() +
                                    "\nInterés ganado en ahorros: " + interes.ToString("F2") +
                                    "\nNuevo saldo en ahorros: " + cuentaahorros.darSaldoAhorros().ToString("F2"));
                }
      




                else if (cdt != null && cdt.darValorinvertido() > 0)
                {
                    decimal valorPresente = cdt.ValorPresente(mes);

                    txtSaldocdt.Text = valorPresente.ToString("F2");
                    txtTotal.Text = (cuentaahorros.darSaldoAhorros() + cuentacorriente.darSaldo() + valorPresente).ToString("F2");

                    MessageBox.Show("Mes ingresado: " + mes.darMes() + "/" + mes.darAnio() +
                                    "\nValor actual del CDT: " + valorPresente.ToString("F2"));
                }
                else
                {
                    MessageBox.Show("No hay saldo en ahorros ni inversión en CDT.");
                }
            }
            catch
            {
                MessageBox.Show("Error: ingrese un número válido para el mes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAbririnversioncdt_Click(object sender, EventArgs e)
        {

            if (txtSaldocdt.Text == "" || txtSaldocdt.Text == "0" || txtSaldocdt.Text == "0.00")
            {
                MessageBox.Show("Campos de Ingreso CDT vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              
                decimal valorInvertido = decimal.Parse(txtSaldocdt.Text);

                decimal interesMensualcdt = 0.006M;

  
                cdt = new CDT((int)valorInvertido, (int)interesMensualcdt);
                cdt.Invertir(valorInvertido, interesMensualcdt, mes.darMes());

                MessageBox.Show("CDT abierto con éxito.\n" +
                                "Valor invertido: " + valorInvertido.ToString("C2") +
                                "\nInterés mensual: " + (interesMensualcdt * 100) + "%" +
                                "\nMes de apertura: " + mes.darMes() + "/" + mes.darAnio());
            }


        }

        private void btnCerrarinversioncdt_Click(object sender, EventArgs e)
        {

            if (cdt == null || cdt.darValorinvertido() == 0)
            {
                MessageBox.Show("No hay un CDT activo para cerrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Seguro que deseas cerrar el CDT?",
                                                            "Confirmación",
                                                            MessageBoxButtons.OKCancel,
                                                            MessageBoxIcon.Question);


                
                if (confirmacion == DialogResult.OK)
                {
                
                    decimal valorCierre = cdt.Cerrar(mes);

             
                    cuentacorriente.cambiarSaldo(cuentacorriente.darSaldo() + valorCierre);

                    txtSaldocdt.Text = "0";
                    txtSaldocorriente.Text = cuentacorriente.darSaldo().ToString("F2");
                    txtTotal.Text = (cuentaahorros.darSaldoAhorros() + cuentacorriente.darSaldo()).ToString("F2");

                    MessageBox.Show("CDT cerrado.\n" +
                                    "Monto transferido a cuenta corriente: " + valorCierre.ToString("C2") +
                                    "\nNuevo saldo en cuenta corriente: " + cuentacorriente.darSaldo().ToString("C2"));
                }


            }
        }

        private void btnConsignarcuentacorriente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSaldocorriente.Text))
                {
                    MessageBox.Show($"Campos de ingreso de datos vacíos",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
   
                    if (decimal.TryParse(txtSaldocorriente.Text, out decimal montoCorriente))
                    {
   
                        cuentacorriente.depositar(montoCorriente);

                  
                        decimal total = cuentaahorros.darSaldoAhorros() + cuentacorriente.darSaldo();

                        if (cdt != null && cdt.darValorinvertido() > 0)
                        {
                            total += cdt.ValorPresente(mes);
                        }

                        txtTotal.Text = total.ToString("F2");

           
                        MessageBox.Show($"Consignación exitosa. El nuevo saldo es: {cuentacorriente.darSaldo():F2}",
                                        "Cuenta Corriente",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor numérico válido.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Error de ingreso de Datos",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }














        }

        private void btnRetirarcuentacorriente_Click(object sender, EventArgs e)
        {
           

        }

        private void btnConsignarcuentaahorro_Click(object sender, EventArgs e)
        {
            
         
        }

        private void btnRetirarcuentaahorro_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldocorriente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSaldoahorros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSaldocdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExtra1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExtra2_Click(object sender, EventArgs e)
        {
    
        }

        private void btnRetirarcuentacorriente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSaldocorriente.Text))
                {
                    MessageBox.Show($"Campos de ingreso de datos Vacíos",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    if (decimal.TryParse(txtSaldocorriente.Text, out decimal montoCorriente))
                    {
                    
                        cuentacorriente.retirar(montoCorriente);

                        decimal total = cuentaahorros.darSaldoAhorros() + cuentacorriente.darSaldo();

                        

                        if (cdt != null && cdt.darValorinvertido() > 0)
                        {
                            total += cdt.ValorPresente(mes);
                        }

                        txtTotal.Text = total.ToString("F2");

                        MessageBox.Show($"Retiro exitoso. El nuevo saldo es: {cuentacorriente.darSaldo():F2}",
                                        "Cuenta Corriente",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor numérico válido.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Error de ingreso de Datos",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }


        }

        private void btnConsignarcuentaahorro_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSaldoahorros.Text))
                {
                    MessageBox.Show($"Campos de ingreso de datos Vacíos",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    if (decimal.TryParse(txtSaldoahorros.Text, out decimal montoAhorros))
                    {

                        cuentaahorros.depositar(montoAhorros);


                        decimal total = cuentaahorros.darSaldoAhorros() + cuentacorriente.darSaldo();

                        if (cdt != null && cdt.darValorinvertido() > 0)
                        {
                            total += cdt.ValorPresente(mes);
                        }

                        txtTotal.Text = total.ToString("F2");


                        MessageBox.Show($"Retiro exitoso. El nuevo saldo es: {cuentaahorros.darSaldoAhorros():F2}",
                                        "Cuenta Corriente",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor numérico válido.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Error de ingreso de Datos",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnRetirarcuentaahorro_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSaldoahorros.Text))
                {
                    MessageBox.Show($"Campos de ingreso de datos Vacíos",
                                    "Advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    if (decimal.TryParse(txtSaldoahorros.Text, out decimal montoAhorros))
                    {
                      
                        cuentaahorros.retirar(montoAhorros);


                        decimal total = cuentaahorros.darSaldoAhorros() + cuentacorriente.darSaldo();

                        if (cdt != null && cdt.darValorinvertido() > 0)
                        {
                            total += cdt.ValorPresente(mes);
                        }

                       
                        txtTotal.Text = total.ToString("F2");

              
                        MessageBox.Show($"Retiro exitoso. El nuevo saldo es: {cuentaahorros.darSaldoAhorros():F2}",
                                        "Cuenta Corriente",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor numérico válido.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Error de ingreso de Datos",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }

        private void txtSaldocdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSaldocorriente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
