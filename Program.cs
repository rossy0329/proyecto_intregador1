# Documento de Prueba de Escritorio

## 1. Prueba de Escritorio: Insertion Sort (Por Préstamos Descendente)

### Datos de entrada (Fragmento reducido de prueba):
- [0] Don Quijote (Préstamos: 20)
- [1] El principito (Préstamos: 20)
- [2] Rayuela (Préstamos: 5)
- [3] Cien años de soledad (Préstamos: 15)

### Traza de Ejecución:
- **i = 1 (clave = El principito, 20):**
  - j = 0 (Quijote, 20). Préstamos iguales (20 == 20).
  - Comparación de título: "Don Quijote" vs "El principito" -> "Don Quijote" va antes. No hay cambio. Preserva estabilidad.
- **i = 2 (clave = Rayuela, 5):**
  - j = 1 (El principito, 20). 20 > 5 -> No intercambia.
- **i = 3 (clave = Cien años de soledad, 15):**
  - j = 2 (Rayuela, 5). 5 < 15 -> Intercambia Rayuela a la posición 3.
  - j = 1 (El principito, 20). 20 > 15 -> Se detiene e inserta "Cien años de soledad" en posición 2.

---

## 2. Prueba de Escritorio: Búsqueda Binaria por ISBN

### Arreglo Ordenado por ISBN:
- [0] 978-01 (Cien años)
- [1] 978-02 (Quijote)
- [2] 978-03 (Principito)
- [3] 978-04 (Fahrenheit)
- [4] 978-05 (Pedro Páramo)
- [5] 978-06 (Rayuela)
- [6] 978-07 (La ciudad)
- [7] 978-08 (Ficciones)

### Búsqueda de ISBN: `978-04`
- **Iteración 1:**
  - `inicio = 0`, `fin = 7`, `medio = (0+7)/2 = 3`
  - Elemento en `[3]` = `978-04`.
  - Comparación: `978-04 == 978-04` -> **¡ENCONTRADO en 1 sola comparación!**# Documento de Prueba de Escritorio

## 1. Prueba de Escritorio: Insertion Sort (Por Préstamos Descendente)

### Datos de entrada (Fragmento reducido de prueba):
- [0] Don Quijote (Préstamos: 20)
- [1] El principito (Préstamos: 20)
- [2] Rayuela (Préstamos: 5)
- [3] Cien años de soledad (Préstamos: 15)

### Traza de Ejecución:
- **i = 1 (clave = El principito, 20):**
  - j = 0 (Quijote, 20). Préstamos iguales (20 == 20).
  - Comparación de título: "Don Quijote" vs "El principito" -> "Don Quijote" va antes. No hay cambio. Preserva estabilidad.
- **i = 2 (clave = Rayuela, 5):**
  - j = 1 (El principito, 20). 20 > 5 -> No intercambia.
- **i = 3 (clave = Cien años de soledad, 15):**
  - j = 2 (Rayuela, 5). 5 < 15 -> Intercambia Rayuela a la posición 3.
  - j = 1 (El principito, 20). 20 > 15 -> Se detiene e inserta "Cien años de soledad" en posición 2.

---

## 2. Prueba de Escritorio: Búsqueda Binaria por ISBN

### Arreglo Ordenado por ISBN:
- [0] 978-01 (Cien años)
- [1] 978-02 (Quijote)
- [2] 978-03 (Principito)
- [3] 978-04 (Fahrenheit)
- [4] 978-05 (Pedro Páramo)
- [5] 978-06 (Rayuela)
- [6] 978-07 (La ciudad)
- [7] 978-08 (Ficciones)

### Búsqueda de ISBN: `978-04`
- **Iteración 1:**
  - `inicio = 0`, `fin = 7`, `medio = (0+7)/2 = 3`
  - Elemento en `[3]` = `978-04`.
  - Comparación: `978-04 == 978-04` -> **¡ENCONTRADO en 1 sola comparación!**