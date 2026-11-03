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

            Console.WriteLine("BÚSQUEDA SECUENCIAL POR TÍTULO");
            BuscarPorTitulo(catalogo, "Pedro Paramo");
            BuscarPorTitulo(catalogo, "Harry Potter"); 

            List<Libro> copiaPorIsbn = new List<Libro>(catalogo);
            OrdenarPorIsbn(copiaPorIsbn);

            Console.WriteLine("\n=== BÚSQUEDA BINARIA POR ISBN ===");
            BuscarPorIsbnBinaria(copiaPorIsbn, "978-04");
            BuscarPorIsbnBinaria(copiaPorIsbn, "978-99"); 
        }

        
        static void BuscarPorTitulo(List<Libro> lista, string tituloBuscado)
        {
            Libro encontrado = null;
            foreach (var libro in lista)
            {
                if (libro.Titulo.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = libro;
                    break;
                }
            }

            if (encontrado != null)
            {
                Console.WriteLine($"[ENCONTRADO] '{encontrado.Titulo}' - Disponibles: {encontrado.ObtenerDisponibles()}/{encontrado.Ejemplares.Length}");
            }
            else
            {
                Console.WriteLine($"[NO ENCONTRADO] El libro con título '{tituloBuscado}' no existe en el catálogo.");
            }
        }

        
        static void BuscarPorIsbnBinaria(List<Libro> lista, string isbnBuscado)
        {
            int inicio = 0;
            int fin = lista.Count - 1;
            Libro encontrado = null;
            int comparaciones = 0;

            while (inicio <= fin)
            {
                comparaciones++;
                int medio = inicio + (fin - inicio) / 2;
                int comparacion = string.Compare(lista[medio].Isbn, isbnBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    encontrado = lista[medio];
                    break;
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            if (encontrado != null)
            {
                Console.WriteLine($"[ENCONTRADO BINARIA] ISBN: {encontrado.Isbn} | Título: '{encontrado.Titulo}' | Quedan: {encontrado.ObtenerDisponibles()} ejemplares | Comparaciones: {comparaciones}");
            }
            else
            {
                Console.WriteLine($"[NO ENCONTRADO BINARIA] El ISBN '{isbnBuscado}' no existe. Comparaciones realizadas: {comparaciones}");
            }
        }

        
        static void OrdenarPorIsbn(List<Libro> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Libro clave = lista[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(lista[j].Isbn, clave.Isbn, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = clave;
            }
        }
    }
}