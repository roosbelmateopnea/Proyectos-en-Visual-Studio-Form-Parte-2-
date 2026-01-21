using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elempleado
{
    internal class Persona
    {
       
        private string nombre;
        private string apellido;
        private char genero;
        private PictureBox foto;
        private Fecha fechaNacimiento;

        // Constructor
        public Persona(string pNombre, string pApellido, char pGenero)
        {
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.fechaNacimiento = new Fecha();
        }

        // Constructor con fecha de nacimiento
        public Persona(string pNombre, string pApellido, char pGenero, Fecha pFechaNacimiento)
        {
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.fechaNacimiento = pFechaNacimiento;
        }

        //  Get
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
        public string darApellido()
        {
            return this.apellido;
        }

        // Set
        public void cambiarApellido(string pApellido)
        {
            this.apellido = pApellido;
        }

        // Get
        public char darGenero()
        {
            return this.genero;
        }

        // Set
        public void cambiarGenero(char pGenero)
        {
            this.genero = pGenero;
        }

        // Get
        public Fecha darFechanacimiento()
        {
            return this.fechaNacimiento;
        }

        // Set
        public void cambiarFechaNacimiento(Fecha pFechaNacimiento)
        {
            this.fechaNacimiento = pFechaNacimiento;
        }

        // Get foto
        public PictureBox darFoto()
        {
            return this.foto;
        }

        // Set foto
        public void cambiarFoto(PictureBox pFoto)
        {
            this.foto = pFoto;
        }
    }
}

