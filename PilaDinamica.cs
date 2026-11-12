
using EstructurasLinealesDinamicas.Models;

namespace EstructurasLinealesDinamicas.Structures
{
    public class PilaDinamica<T>
    {
        private Nodo<T>? top;

        public int Count { get; private set; }

        public bool IsEmpty()
        {
            return top == null;
        }

        // Insertar un elemento
        public void Push(T data)
        {
            Nodo<T> nuevo = new Nodo<T>(data);

            nuevo.Next = top;
            top = nuevo;

            Count++;
        }

        // Eliminar el elemento superior
        public T? Pop()
        {
            if (IsEmpty())
                return default;

            T data = top!.Data;

            top = top.Next;
            Count--;

            return data;
        }

        // Consultar el elemento superior
        public T? Peek()
        {
            if (IsEmpty())
                return default;

            return top!.Data;
        }

        // Mostrar los elementos
        public void Display()
        {
            Nodo<T>? actual = top;

            if (IsEmpty())
            {
                Console.WriteLine("La pila esta vacia.");
                return;
            }

            while (actual != null)
            {
                Console.WriteLine(actual.Data);
                actual = actual.Next;
            }
        }
    }
}
