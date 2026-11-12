
namespace EstructurasLinealesDinamicas.Models
{
    public class Nodo<T>
    {
        public T Data { get; set; }

        public Nodo<T>? Next { get; set; }

        public Nodo(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
