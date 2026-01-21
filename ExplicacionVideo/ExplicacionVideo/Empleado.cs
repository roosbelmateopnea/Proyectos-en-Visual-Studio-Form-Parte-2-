using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionVideo
{
    public class Empleado
    {
        public string nombre;
        public string identificacion;
        public decimal asignacionDia;


        public string Nombre { get; set; }

        public string Identificacion { get; set; }

        public decimal AsignacionDia { get; set; }



        public Empleado(string pNombre,string pIdentificacion, decimal pAsignacionDia)
        {
            this.nombre = pNombre;
            this.identificacion = pIdentificacion;
            this.asignacionDia = pAsignacionDia;
        }





    }
}



