using System;
using System.Collections.Generic;

namespace BibliotecaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> catalogo = new List<Libro>()
            {
                new Libro("978-01", "Cien anos de soledad", 15, 5),
                new Libro("978-02", "Don Quijote de la Mancha", 20, 3),
                new Libro("978-03", "El principito", 20, 1),
                new Libro("978-04", "Fahrenheit 451", 8, 4),
                new Libro("978-05", "Pedro Paramo", 12, 2),
                new Libro("978-06", "Rayuela", 5, 1),
                new Libro("978-07", "La ciudad y los perros", 18, 5),
                new Libro("978-08", "Ficciones", 10, 2)
            };

            Console.WriteLine("=== CATALOGO ANTES DE LOS PRESTAMOS ===");
            MostrarCatalogo(catalogo);

            // Simulacion de 3 prestamos
            Console.WriteLine("\n--- SIMULANDO 3 PRESTAMOS ---");
            RealizarPrestamoSimulado(catalogo[0]); // Prestamo 1: Cien anos de soledad
            RealizarPrestamoSimulado(catalogo[2]); // Prestamo 2: El principito
            RealizarPrestamoSimulado(catalogo[2]); // Prestamo 3: El principito (ya no tiene copias)

            Console.WriteLine("\n=== CATALOGO DESPUES DE LOS PRESTAMOS ===");
            MostrarCatalogo(catalogo);
        }

        static void MostrarCatalogo(List<Libro> lista)
        {
            foreach (var libro in lista)
            {
                Console.WriteLine($"ISBN: {libro.Isbn} | Titulo: {libro.Titulo,-25} | Prestamos Hist.: {libro.PrestamosHistoricos,2} | Disponibles: {libro.ObtenerDisponibles()}/{libro.Ejemplares.Length}");
            }
        }

        static void RealizarPrestamoSimulado(Libro libro)
        {
            if (libro.RegistrarPrestamo())
            {
                Console.WriteLine($"[EXITO] Se presto una copia de '{libro.Titulo}'. Quedan: {libro.ObtenerDisponibles()}");
            }
            else
            {
                Console.WriteLine($"[ERROR] No hay ejemplares disponibles para '{libro.Titulo}'.");
            }
        }
    }
}