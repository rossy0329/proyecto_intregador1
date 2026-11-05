# Sistema de Gestión de Biblioteca Escolar

Proyecto integrador desarrollado en C# (.NET Core) para la gestión y control de catálogo, préstamos e inventario en una biblioteca escolar.

# Caracteristicas
- Modelo Orientado a Objetos: Estructura dinámica en `List<Libro>` sin celdas vacías en memoria.
- Historial y Disponibilidad: Control automático de copias disponibles y préstamos acumulados.
- Ordenamiento Manual: Algoritmo de **Inserción (Insertion Sort)** ordenando por popularidad de préstamos y manteniendo estabilidad alfabética.
- Búsqueda Eficiente: Implementación de **Búsqueda Binaria** por ISBN ($O(\log n)$) y **Búsqueda Secuencial** por título.

# Requisitos
- Visual Studio 2022 o SDK de .NET 6.0+

# Compilación y Ejecución
1. Clonar el repositorio:
   ```bash
   git clone [https://github.com/tu-usuario/proyecto-biblioteca-escolar.git](https://github.com/tu-usuario/proyecto-biblioteca-escolar.git)# proyecto_intregador1