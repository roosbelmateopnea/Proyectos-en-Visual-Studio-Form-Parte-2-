using System;

namespace almacenamiento
{
    // Clase estática para guardar datos que quieras reutilizar en cualquier formulario
    public static class DatosCompartidos
    {
        public static string Nombre { get; set; }
        public static string Documento { get; set; }
        public static int? Edad { get; set; }
        public static decimal? Saldo { get; set; }

        // (Opcional) método para limpiar todo
        public static void Limpiar()
        {
            Nombre = null;
            Documento = null;
            Edad = null;
            Saldo = null;
        }
    }
}
