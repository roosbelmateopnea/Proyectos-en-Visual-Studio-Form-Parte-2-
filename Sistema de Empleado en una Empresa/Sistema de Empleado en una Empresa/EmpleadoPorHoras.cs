using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Empleado_en_una_Empresa
{
    internal class EmpleadoPorHoras:Empleado
    {
        private int horasTrabajadas;
        private decimal valorHora;

        //Constructor
        public EmpleadoPorHoras(string pNombre,string pIdentificacion,decimal pSalarioBase,int pHorasTrabajadas, decimal pValorHora) :base (pNombre,pIdentificacion,pSalarioBase)
        {
            this.horasTrabajadas = pHorasTrabajadas;
            this.valorHora = pValorHora;
        }

        public EmpleadoPorHoras(string pNombre, string pIdentificacion,decimal pSalarioBase,int pHorasTrabajadas,decimal pValorHora) :base(pNombre, pIdentificacion, pSalarioBase)

        {
            this.horasTrabajadas = pHorasTrabajadas;
            this.valorHora = pValorHora;
        }
       








    }

}
