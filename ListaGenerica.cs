
using EstructurasLinealesDinamicas.Models;

namespace EstructurasLinealesDinamicas.Structures
{
    public class ListaGenerica<T>
    {
        private Nodo<T>? head;

        public int Count { get; private set; }

        public bool IsEmpty()
        {
            return head == null;
        }

        // Agregar al final
        public void Add(T data)
        {
            Nodo<T> nuevo = new Nodo<T>(data);

            if (IsEmpty())
            {
                head = nuevo;
            }
            else
            {
                Nodo<T> actual = head!;

                while (actual.Next != null)
                    actual = actual.Next;

                actual.Next = nuevo;
            }

            Count++;
        }

        // Insertar en una posicion
        public bool Insert(int posicion, T data)
        {
            if (posicion < 0 || posicion > Count)
                return false;

            Nodo<T> nuevo = new Nodo<T>(data);

            if (posicion == 0)
            {
                nuevo.Next = head;
                head = nuevo;
            }
            else
            {
                Nodo<T> actual = head!;

                for (int i = 0; i < posicion - 1; i++)
                    actual = actual.Next!;

                nuevo.Next = actual.Next;
                actual.Next = nuevo;
            }

            Count++;
            return true;
        }

        // Buscar un elemento
        public bool Search(T data)
        {
            Nodo<T>? actual = head;

            while (actual != null)
            {
                if (EqualityComparer<T>.Default.Equals(
                    actual.Data, data))
                    return true;

                actual = actual.Next;
            }

            return false;
        }

        // Obtener elemento por posicion
        public T? Get(int posicion)
        {
            if (posicion < 0 || posicion >= Count)
                return default;

            Nodo<T>? actual = head;

            for (int i = 0; i < posicion; i++)
                actual = actual!.Next;

            return actual!.Data;
        }

        // Eliminar un elemento
        public bool Remove(T data)
        {
            if (IsEmpty())
                return false;

            if (EqualityComparer<T>.Default.Equals(
                head!.Data, data))
            {
                head = head.Next;
                Count--;
                return true;
            }

            Nodo<T>? actual = head;

            while (actual!.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(
                    actual.Next.Data, data))
                {
                    actual.Next = actual.Next.Next;
                    Count--;
                    return true;
                }

                actual = actual.Next;
            }

            return false;
        }

        // Mostrar lista
        public void Display()
        {
            Nodo<T>? actual = head;

            if (IsEmpty())
            {
                Console.WriteLine("La lista esta vacia.");
                return;
            }

            while (actual != null)
            {
                Console.Write(actual.Data + " -> ");
                actual = actual.Next;
            }

            Console.WriteLine("null");
        }
    }
}
