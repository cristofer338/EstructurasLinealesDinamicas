
using EstructurasLinealesDinamicas.Structures;

ListaEnlazada<int> lista = new ListaEnlazada<int>();
PilaDinamica<int> pila = new PilaDinamica<int>();
ColaDinamica<int> cola = new ColaDinamica<int>();
ListaGenerica<int> listaGenerica = new ListaGenerica<int>();

int opcion;

do
{
    Console.WriteLine("\n===== ESTRUCTURAS LINEALES DINAMICAS =====");
    Console.WriteLine("1. Lista simplemente enlazada");
    Console.WriteLine("2. Pila dinamica");
    Console.WriteLine("3. Cola dinamica");
    Console.WriteLine("4. Lista generica");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opcion: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opcion no valida.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            MenuLista(lista);
            break;

        case 2:
            MenuPila(pila);
            break;

        case 3:
            MenuCola(cola);
            break;

        case 4:
            MenuListaGenerica(listaGenerica);
            break;

        case 0:
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("Opcion incorrecta.");
            break;
    }

} while (opcion != 0);


// MENU LISTA ENLAZADA
static void MenuLista(ListaEnlazada<int> lista)
{
    int opcion;

    do
    {
        Console.WriteLine("\n--- LISTA ENLAZADA ---");
        Console.WriteLine("1. Agregar");
        Console.WriteLine("2. Eliminar");
        Console.WriteLine("3. Buscar");
        Console.WriteLine("4. Mostrar");
        Console.WriteLine("0. Regresar");

        opcion = LeerOpcion();

        switch (opcion)
        {
            case 1:
                lista.Add(LeerNumero());
                break;

            case 2:
                Console.WriteLine(lista.Remove(LeerNumero())
                    ? "Elemento eliminado."
                    : "Elemento no encontrado.");
                break;

            case 3:
                Console.WriteLine(lista.Search(LeerNumero())
                    ? "Elemento encontrado."
                    : "Elemento no encontrado.");
                break;

            case 4:
                lista.Display();
                break;
        }

    } while (opcion != 0);
}


// MENU PILA
static void MenuPila(PilaDinamica<int> pila)
{
    int opcion;

    do
    {
        Console.WriteLine("\n--- PILA DINAMICA ---");
        Console.WriteLine("1. Push");
        Console.WriteLine("2. Pop");
        Console.WriteLine("3. Peek");
        Console.WriteLine("4. Mostrar");
        Console.WriteLine("0. Regresar");

        opcion = LeerOpcion();

        switch (opcion)
        {
            case 1:
                pila.Push(LeerNumero());
                break;

            case 2:
                var eliminado = pila.Pop();
                Console.WriteLine(eliminado == null
                    ? "Pila vacia."
                    : "Eliminado: " + eliminado);
                break;

            case 3:
                var superior = pila.Peek();
                Console.WriteLine(superior == null
                    ? "Pila vacia."
                    : "Superior: " + superior);
                break;

            case 4:
                pila.Display();
                break;
        }

    } while (opcion != 0);
}


// MENU COLA
static void MenuCola(ColaDinamica<int> cola)
{
    int opcion;

    do
    {
        Console.WriteLine("\n--- COLA DINAMICA ---");
        Console.WriteLine("1. Enqueue");
        Console.WriteLine("2. Dequeue");
        Console.WriteLine("3. Peek");
        Console.WriteLine("4. Mostrar");
        Console.WriteLine("0. Regresar");

        opcion = LeerOpcion();

        switch (opcion)
        {
            case 1:
                cola.Enqueue(LeerNumero());
                break;

            case 2:
                var eliminado = cola.Dequeue();
                Console.WriteLine(eliminado == null
                    ? "Cola vacia."
                    : "Eliminado: " + eliminado);
                break;

            case 3:
                var primero = cola.Peek();
                Console.WriteLine(primero == null
                    ? "Cola vacia."
                    : "Primero: " + primero);
                break;

            case 4:
                cola.Display();
                break;
        }

    } while (opcion != 0);
}


// MENU LISTA GENERICA
static void MenuListaGenerica(ListaGenerica<int> lista)
{
    int opcion;

    do
    {
        Console.WriteLine("\n--- LISTA GENERICA ---");
        Console.WriteLine("1. Agregar");
        Console.WriteLine("2. Insertar por posicion");
        Console.WriteLine("3. Eliminar");
        Console.WriteLine("4. Buscar");
        Console.WriteLine("5. Obtener por posicion");
        Console.WriteLine("6. Mostrar");
        Console.WriteLine("0. Regresar");

        opcion = LeerOpcion();

        switch (opcion)
        {
            case 1:
                lista.Add(LeerNumero());
                break;

            case 2:
                Console.Write("Posicion: ");
                int posicion = LeerNumero();
                int valor = LeerNumero();

                Console.WriteLine(lista.Insert(posicion, valor)
                    ? "Insertado correctamente."
                    : "Posicion invalida.");
                break;

            case 3:
                Console.WriteLine(lista.Remove(LeerNumero())
                    ? "Elemento eliminado."
                    : "Elemento no encontrado.");
                break;

            case 4:
                Console.WriteLine(lista.Search(LeerNumero())
                    ? "Elemento encontrado."
                    : "Elemento no encontrado.");
                break;

            case 5:
                Console.Write("Posicion: ");
                int indice = LeerNumero();
                var resultado = lista.Get(indice);

                Console.WriteLine(resultado == null
                    ? "Posicion invalida."
                    : "Elemento: " + resultado);
                break;

            case 6:
                lista.Display();
                break;
        }

    } while (opcion != 0);
}


// FUNCIONES AUXILIARES
static int LeerOpcion()
{
    Console.Write("Selecciona una opcion: ");

    if (int.TryParse(Console.ReadLine(), out int opcion))
        return opcion;

    return -1;
}

static int LeerNumero()
{
    int numero;

    while (true)
    {
        Console.Write("Ingresa un numero: ");

        if (int.TryParse(Console.ReadLine(), out numero))
            return numero;

        Console.WriteLine("Numero invalido.");
    }
}
