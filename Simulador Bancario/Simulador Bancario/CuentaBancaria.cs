using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Bancario
{
    internal class CuentaBancaria
    {
        private string cedula;
        private string nombre;
     

        // Constructor
        public CuentaBancaria(string pCedula, string pNombre)
        {
            this.cedula = pCedula;
            this.nombre = pNombre;
           
        }

        // Get
        public string darCedula()
        {
            return this.cedula;
        }

        // Set
        public void cambiarCedula(string pCedula)
        {
            this.cedula = pCedula;
        }

        // Get
        public string darNombre()
        {
            return this.nombre;
        }

        // Set
        public void cambiarNombre(string pNombre)
        {
            this.nombre = pNombre;
        }

        // Get
        
    }
}
