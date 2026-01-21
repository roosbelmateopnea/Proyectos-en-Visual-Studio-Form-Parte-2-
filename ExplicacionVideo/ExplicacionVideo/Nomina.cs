using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionVideo
{
    public class Nomina
    {


        public int diasLaborados;

        public int DiasLaborados { get; set; }


        public Nomina( int pDiasLaborados)
        {
            this.DiasLaborados = pDiasLaborados;
        }

        

        public decimal CalcularSalario(int diasLaborados, decimal asignacionDia)
        {
            decimal salario = diasLaborados * asignacionDia;
            return salario;


          
        }


     

        
    }
}
