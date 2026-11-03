using System;

namespace BibliotecaEscolar
{
    public class Libro
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public int PrestamosHistoricos { get; set; }
        public int[] Ejemplares { get; set; } // Arreglo exacto por libro sin celdas vacias

        public Libro(string isbn, string titulo, int prestamos, int cantidadEjemplares)
        {
            Isbn = isbn;
            Titulo = titulo;
            PrestamosHistoricos = prestamos;

            Ejemplares = new int[cantidadEjemplares];
            for (int i = 0; i < cantidadEjemplares; i++)
            {
                Ejemplares[i] = 1; // 1 = Disponible, 0 = Prestado
            }
        }

        
        public int ObtenerDisponibles()
        {
            int disponibles = 0;
            foreach (int estado in Ejemplares)
            {
                if (estado == 1) disponibles++;
            }
            return disponibles;
        }

        
        public bool RegistrarPrestamo()
        {
            for (int i = 0; i < Ejemplares.Length; i++)
            {
                if (Ejemplares[i] == 1)
                {
                    Ejemplares[i] = 0; // Marcar como prestado
                    PrestamosHistoricos++; // Incrementar contador historico
                    return true;
                }
            }
            return false; // No hay ejemplares disponibles
        }
    }
}