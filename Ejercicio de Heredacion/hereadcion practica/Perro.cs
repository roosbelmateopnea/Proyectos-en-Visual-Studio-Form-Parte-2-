using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hereadcion_practica
{
    internal class Perro : Animal
    {
        public string Raza { get; set; }
        public string Sonido { get; set; }

        // Constructor que hereda de Animal y agrega propiedades de Perro
        public Perro(string nombre, string genero, string raza, string sonido)
            : base(nombre, genero)
        {
            Raza = raza;
            Sonido = sonido;
        }

        // Método para mostrar información
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Género: {Genero}, Raza: {Raza}, Sonido: {Sonido}";
        }
    }
}
