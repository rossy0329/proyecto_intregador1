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
                new Libro("978-03", "El principito", 20, 1), // Mismos préstamos que Quijote (20) para probar estabilidad
                new Libro("978-04", "Fahrenheit 451", 8, 4),
                new Libro("978-05", "Pedro Paramo", 12, 2),
                new Libro("978-06", "Rayuela", 5, 1),
                new Libro("978-07", "La ciudad y los perros", 18, 5),
                new Libro("978-08", "Ficciones", 10, 2)
            };

            Console.WriteLine("=== CATALOGO ORIGINAL ===");
            MostrarCatalogo(catalogo);

            // Aplicar ordenamiento por inserción manual
            OrdenarPorInsercion(catalogo);

            Console.WriteLine("\n=== CATALOGO ORDENADO POR PRESTAMOS (MAYOR A MENOR) ===");
            MostrarCatalogo(catalogo);
        }

        // Algoritmo de Ordenamiento por Inserción Manual (Estable)
        static void OrdenarPorInsercion(List<Libro> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Libro clave = lista[i];
                int j = i - 1;

                // Ordenar de mayor a menor por préstamos.
                // Si empatan en préstamos, se preserva el orden alfabético original.
                while (j >= 0 && DebeIntercambiar(lista[j], clave))
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = clave;
            }
        }

        static bool DebeIntercambiar(Libro actual, Libro clave)
        {
            // Criterio 1: Mayor número de préstamos
            if (actual.PrestamosHistoricos < clave.PrestamosHistoricos)
            {
                return true;
            }
            // Criterio 2: Si empatan en préstamos, ordenar alfabéticamente por título
            else if (actual.PrestamosHistoricos == clave.PrestamosHistoricos)
            {
                return string.Compare(actual.Titulo, clave.Titulo, StringComparison.OrdinalIgnoreCase) > 0;
            }

            return false;
        }

        static void MostrarCatalogo(List<Libro> lista)
        {
            foreach (var libro in lista)
            {
                Console.WriteLine($"ISBN: {libro.Isbn} | Titulo: {libro.Titulo,-25} | Prestamos Hist.: {libro.PrestamosHistoricos,2} | Disponibles: {libro.ObtenerDisponibles()}/{libro.Ejemplares.Length}");
            }
        }
    }
}