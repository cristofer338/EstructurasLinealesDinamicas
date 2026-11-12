
using EstructurasLinealesDinamicas.Models;

namespace EstructurasLinealesDinamicas.Structures
{
    public class ListaEnlazada<T>
    {
        private Nodo<T>? head;

        public int Count { get; private set; }

        public bool IsEmpty()
        {
            return head == null;
        }

        // Insertar un elemento al final
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
                {
                    actual = actual.Next;
                }

                actual.Next = nuevo;
            }

            Count++;
        }

        // Buscar un elemento
        public bool Search(T data)
        {
            Nodo<T>? actual = head;

            while (actual != null)
            {
                if (EqualityComparer<T>.Default.Equals(actual.Data, data))
                {
                    return true;
                }

                actual = actual.Next;
            }

            return false;
        }

        // Eliminar la primera coincidencia
        public bool Remove(T data)
        {
            if (IsEmpty())
                return false;

            if (EqualityComparer<T>.Default.Equals(head!.Data, data))
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

        // Mostrar todos los elementos
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
