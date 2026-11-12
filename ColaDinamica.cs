
using EstructurasLinealesDinamicas.Models;

namespace EstructurasLinealesDinamicas.Structures
{
    public class ColaDinamica<T>
    {
        private Nodo<T>? front;
        private Nodo<T>? rear;

        public int Count { get; private set; }

        public bool IsEmpty()
        {
            return front == null;
        }

        // Insertar al final
        public void Enqueue(T data)
        {
            Nodo<T> nuevo = new Nodo<T>(data);

            if (IsEmpty())
            {
                front = nuevo;
                rear = nuevo;
            }
            else
            {
                rear!.Next = nuevo;
                rear = nuevo;
            }

            Count++;
        }

        // Eliminar el primer elemento
        public T? Dequeue()
        {
            if (IsEmpty())
                return default;

            T data = front!.Data;

            front = front.Next;
            Count--;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }

        // Consultar el primer elemento
        public T? Peek()
        {
            if (IsEmpty())
                return default;

            return front!.Data;
        }

        // Mostrar elementos
        public void Display()
        {
            Nodo<T>? actual = front;

            if (IsEmpty())
            {
                Console.WriteLine("La cola esta vacia.");
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
