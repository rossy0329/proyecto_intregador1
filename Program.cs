using System;
using System.Collections.Generic;

namespace BibliotecaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // carga inicial de 8 títulos con ejemplares irregulares (sin celdas vacías)
            List<Libro> catalogo = new List<Libro>()
            {
                new Libro("978-01", "Cien anos de soledad", 15, 5),
                new Libro("978-02", "Don Quijote de la Mancha", 20, 3),
                new Libro("978-03", "El principito", 20, 1), // Mismos préstamos que Quijote para probar estabilidad
                new Libro("978-04", "Fahrenheit 451", 8, 4),
                new Libro("978-05", "Pedro Paramo", 12, 2),
                new Libro("978-06", "Rayuela", 5, 1),
                new Libro("978-07", "La ciudad y los perros", 18, 5),
                new Libro("978-08", "Ficciones", 10, 2)
            };

            Console.WriteLine("=== CATALOGO INICIAL CARGADO EXITOSAMENTE ===");
            foreach (var libro in catalogo)
            {
                Console.WriteLine($"ISBN: {libro.Isbn} | Titulo: {libro.Titulo} | Prestamos: {libro.PrestamosHistoricos} | Copias: {libro.Ejemplares.Length}");
            }
        }
    }
}