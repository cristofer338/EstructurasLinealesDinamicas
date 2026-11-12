# 📚 Estructuras Lineales Dinámicas en C#

**Unidad 3 – Estructuras Lineales | Tarea 3.2**

## 📌 Descripción del proyecto

Este proyecto consiste en la implementación de estructuras de datos lineales dinámicas utilizando el lenguaje de programación C#.

Se desarrollan listas enlazadas, pilas y colas mediante nodos dinámicos, aplicando conceptos de programación genérica, referencias entre objetos y administración dinámica de memoria.

El propósito es comprender el funcionamiento de estas estructuras y analizar sus diferencias respecto a las implementaciones estáticas mediante arreglos.

---

## 🎯 Objetivo general

Implementar estructuras de datos lineales dinámicas mediante nodos y referencias, comprendiendo sus operaciones principales, características, ventajas y desventajas frente al almacenamiento estático.

## 🎯 Objetivos específicos

- Implementar una lista simplemente enlazada mediante nodos dinámicos.
- Desarrollar una pila dinámica utilizando el principio LIFO.
- Implementar una cola dinámica utilizando el principio FIFO.
- Crear estructuras genéricas reutilizables mediante `T`.
- Comprender el funcionamiento de las referencias entre nodos.
- Comparar el almacenamiento estático y dinámico en memoria.

---

## 🧩 Estructuras implementadas

### 1. Nodo genérico (Nodo<T>)

Es la unidad fundamental de las estructuras dinámicas.

**Características:**
- Almacena información mediante la propiedad `Data`.
- Utiliza `Next` para enlazarse con otro nodo.
- Permite almacenar diferentes tipos de datos.
- Se crea dinámicamente mediante el operador `new`.

### 2. Lista simplemente enlazada (ListaEnlazada<T>)

Estructura que permite almacenar elementos conectados mediante referencias entre nodos.

**Operaciones implementadas:**

| Método | Descripción |
|---|---|
| `Add()` | Agrega un elemento al final. |
| `Remove()` | Elimina la primera coincidencia. |
| `Search()` | Busca un elemento. |
| `Display()` | Muestra todos los elementos. |
| `IsEmpty()` | Comprueba si está vacía. |
| `Count` | Obtiene la cantidad de elementos. |

### 3. Pila dinámica (PilaDinamica<T>)

Estructura que utiliza el principio **LIFO (Last In, First Out)**, donde el último elemento en ingresar es el primero en salir.

**Operaciones implementadas:**

| Método | Descripción |
|---|---|
| `Push()` | Inserta un elemento en la parte superior. |
| `Pop()` | Elimina y devuelve el elemento superior. |
| `Peek()` | Consulta el elemento superior. |
| `IsEmpty()` | Comprueba si está vacía. |
| `Display()` | Muestra los elementos. |
| `Count` | Cuenta los elementos. |

### 4. Cola dinámica (ColaDinamica<T>)

Estructura que utiliza el principio **FIFO (First In, First Out)**, donde el primer elemento en ingresar es el primero en salir.

**Operaciones implementadas:**

| Método | Descripción |
|---|---|
| `Enqueue()` | Inserta un elemento al final. |
| `Dequeue()` | Elimina y devuelve el primer elemento. |
| `Peek()` | Consulta el primer elemento. |
| `IsEmpty()` | Comprueba si está vacía. |
| `Display()` | Muestra los elementos. |
| `Count` | Cuenta los elementos. |

### 5. Lista dinámica genérica (ListaGenerica<T>)

Implementación de una lista enlazada que permite trabajar con diferentes tipos de datos.

**Operaciones implementadas:**

| Método | Descripción |
|---|---|
| `Add()` | Agrega un elemento al final. |
| `Insert()` | Inserta un elemento en una posición específica. |
| `Remove()` | Elimina la primera coincidencia. |
| `Search()` | Busca un elemento. |
| `Get()` | Obtiene un elemento por posición. |
| `Display()` | Muestra los elementos. |
| `IsEmpty()` | Comprueba si está vacía. |

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 8 o superior.
- **Entorno de desarrollo:** Visual Studio 2022.
- **Tipo de aplicación:** Consola.
- **Paradigma:** Programación orientada a objetos.
- **Estructuras:** Nodos dinámicos y listas enlazadas.
- **Programación genérica:** Clases mediante el tipo `T`.
- **Control de versiones:** Git y GitHub.

## 📁 Organización del proyecto

```text
EstructurasLinealesDinamicas/
│
├── Program.cs
│
├── Models/
│   └── Nodo.cs
│
├── Structures/
│   ├── ListaEnlazada.cs
│   ├── PilaDinamica.cs
│   ├── ColaDinamica.cs
│   └── ListaGenerica.cs
│
├── Evidencias/
│   ├── ListaEnlazada.png
│   ├── PilaDinamica.png
│   ├── ColaDinamica.png
│   └── ListaGenerica.png
│
└── README.md
```

---

## ▶️ Instalación y ejecución

1. Clonar el repositorio desde GitHub.
2. Abrir el proyecto en Visual Studio 2022.
3. Verificar que esté instalado .NET 8 o superior.
4. Compilar la solución.
5. Ejecutar la aplicación de consola.
6. Seleccionar la estructura que se desea utilizar desde el menú principal.

También se puede ejecutar desde una terminal ubicada en la carpeta del proyecto:

```bash
dotnet restore
dotnet build
dotnet run
```

---

## 🧪 Pruebas de funcionamiento

Se proponen las siguientes pruebas para comprobar el funcionamiento de las estructuras:

| Estructura | Operación | Resultado esperado |
|---|---|---|
| Lista enlazada | Agregar 10, 20 y 30 | 10 → 20 → 30 |
| Lista enlazada | Eliminar 20 | 10 → 30 |
| Pila dinámica | Insertar 10, 20 y 30 | Superior: 30 |
| Pila dinámica | Ejecutar Pop | Elimina 30 |
| Cola dinámica | Insertar 10, 20 y 30 | Primero: 10 |
| Cola dinámica | Ejecutar Dequeue | Elimina 10 |
| Lista genérica | Insertar 50 en posición 1 | Inserción correcta |
| Lista genérica | Buscar 50 | Elemento encontrado |

---

## 📊 Comparación: memoria estática vs. memoria dinámica

| Característica | Estática | Dinámica |
|---|---|---|
| Almacenamiento | Arreglos | Nodos |
| Capacidad | Fija | Variable |
| Asignación | Tamaño reservado | Según necesidad |
| Acceso | Directo por índice | Recorrido por referencias |
| Memoria adicional | Generalmente menor | Sobrecarga por referencias |
| Flexibilidad | Limitada | Mayor |

### Ventajas de las estructuras dinámicas

- Permiten crecer y reducirse según las necesidades.
- No requieren establecer una capacidad máxima inicial.
- Facilitan la inserción y eliminación de elementos en determinadas posiciones.
- Aprovechan la memoria según la cantidad de elementos almacenados.

### Desventajas de las estructuras dinámicas

- Requieren memoria adicional para las referencias.
- Pueden tener mayor complejidad de implementación.
- El acceso a posiciones específicas puede requerir recorridos.
- La administración de memoria puede generar sobrecarga.

---

## 📸 Evidencias de funcionamiento

En esta sección se incorporarán capturas de pantalla que demuestren la ejecución y el funcionamiento de cada estructura.

- Lista simplemente enlazada.
- Pila dinámica.
- Cola dinámica.
- Lista dinámica genérica.

Las evidencias se almacenan en la carpeta `Evidencias`.

---

## 📖 Conclusión

El desarrollo de este proyecto permitió comprender la implementación de estructuras lineales dinámicas mediante nodos y referencias, aplicando los principios de programación orientada a objetos y programación genérica en C#.

Se identificó que las estructuras dinámicas ofrecen mayor flexibilidad en la administración de memoria, ya que pueden aumentar o disminuir su tamaño durante la ejecución.

Asimismo, se comprendieron las diferencias entre pilas, colas y listas enlazadas, así como sus aplicaciones y operaciones fundamentales.

## 👨‍💻 Autor

Proyecto académico desarrollado como parte de la asignatura **Estructuras de Datos**, correspondiente a la Unidad 3: Estructuras Lineales.

