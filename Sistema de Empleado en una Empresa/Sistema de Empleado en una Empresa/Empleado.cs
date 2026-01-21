using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Empleado_en_una_Empresa
{
    internal class Empleado
    {
        private string nombre;
        private string identificacion;
        private decimal salarioBase;



        public Empleado(string pNombre,string pIdentificacion,decimal pSalarioBase)
        {
            this.nombre = pNombre;
            this.identificacion = pIdentificacion;
            this.salarioBase = pSalarioBase;

        }

        public Empleado(string pNombre, string pIdentificacion)
        {
            this.nombre = pNombre;
            this.identificacion = pIdentificacion;
            this.salarioBase = 1000000;
        }

        //Get
        public string darNombre()
        {
            return this.nombre;
        }

        //Set
        public void cambiarNombre(string pNombre)
        {
            this.nombre = pNombre;
        }

        //Get
        public string darIdentificacion()
        {
            return this.identificacion;
        }

        //Set
        public void cambiarIdentifiacion(string pIdentificacion)
        {
            this.identificacion = pIdentificacion;
        }
        //Get
        public decimal darSalarioBase()
        {
            return this.salarioBase;
        }

        //Set
        public void cambiarSalario(decimal pSalarioBase)
        {
            this.salarioBase = pSalarioBase;
        }

        public decimal calcularSalario()
        {
            return this.salarioBase;
        }


    }
}
