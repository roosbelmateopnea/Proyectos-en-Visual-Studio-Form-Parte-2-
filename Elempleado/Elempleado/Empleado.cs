using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elempleado
{
     internal class Empleado: Persona
    {
        private Fecha fechaIngreso;
        private decimal salario;
        private string cargo;
        private const decimal SALARIO_MINIMO = 1423500;
        private const decimal PORCENTAJE_SALUD = 0.04m;
        private const decimal PORCENTAJE_LIBRANZA = 0.3m;

        public Empleado(string pNombre, string pApellido, char pGenero) :base(pNombre, pApellido, pGenero)
        {
            this.salario = 0;
            this.fechaIngreso = new Fecha();
            this.cargo = "No definido";


        }


        public Empleado(string pNombre, string pApellido, char pGenero,decimal pSalario): base(pNombre,pApellido,pGenero)
        {
            this.salario = pSalario;
            this.fechaIngreso = new Fecha();
            this.cargo = "No definido";
            
        }


        public Empleado(string pNombre,string pApellido,char pGenero,decimal pSalario, 
            Fecha pFechaIngreso, string pCargo, Fecha pFechaNacimiento)

            :base(pNombre, pApellido, pGenero)
        {
            this.salario = pSalario;
            this.fechaIngreso = pFechaIngreso;
            this.cargo = pCargo;


        }

        



        //Get
        public decimal darSalario()
        {
            return this.salario;
        }

        //Set
        public void cambiarSalario(decimal pSalario)
        {
            this.salario = pSalario;
        }


        //Get
        public Fecha darFechaIngreso()
        {
            return this.fechaIngreso;
        }

        //Set
        public void cambiarFechaIngreso(Fecha pFechaIngreso)
        {
            this.fechaIngreso = pFechaIngreso;
        }

        //Get
        public string darCargo()
        {
            return this.cargo;
        }

        //Set
        public void cambiarCargo(string cargo)
        {
            this.cargo = cargo;
        }



        public decimal aporteASalud()
        {
            decimal aporte = 0;
            if (this.salario < SALARIO_MINIMO)
            {
                aporte = SALARIO_MINIMO * PORCENTAJE_SALUD;
            }
            else
            {
                aporte += this.salario * PORCENTAJE_SALUD;
            }
            return aporte;
        }



        public decimal aporteAPension()
        {
            decimal aporte = 0;
            if (this.salario < SALARIO_MINIMO)
            {
                aporte = SALARIO_MINIMO * PORCENTAJE_SALUD;
            }


            else
            {
                aporte += this.salario * PORCENTAJE_SALUD;
            }
            return aporte;
        }



        public decimal valorLibranza()
        {
            return this.salario * PORCENTAJE_LIBRANZA;
        }



        public decimal deducciones()
        {
            return aporteASalud() + aporteAPension() + valorLibranza();
        }


        public decimal netoAPagar()
        {
            return this.salario - deducciones();
        }
    }
}
