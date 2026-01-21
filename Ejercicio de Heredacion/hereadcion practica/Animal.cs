using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hereadcion_practica
{
    internal class Animal
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }

        public Animal(string nombre, string genero)
        {
            Nombre = nombre;
            Genero = genero;
        }

        public void Comer()
        {
            MessageBox.Show($())
        }




    }
}
