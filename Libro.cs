using System;

namespace BibliotecaEscolar
{
    public class Libro
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public int PrestamosHistoricos { get; set; }
        public int[] Ejemplares { get; set; } // Arreglo exacto por libro sin celdas vacías

        public Libro(string isbn, string titulo, int prestamos, int cantidadEjemplares)
        {
            Isbn = isbn;
            Titulo = titulo;
            PrestamosHistoricos = prestamos;

            // Se inicializa el arreglo con el tamaño exacto de ejemplares (1 a 5)
            Ejemplares = new int[cantidadEjemplares];
            for (int i = 0; i < cantidadEjemplares; i++)
            {
                Ejemplares[i] = 1; // 1 indica disponible, 0 prestado
            }
        }
    }
}
