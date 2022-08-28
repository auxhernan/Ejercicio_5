using System.Diagnostics.CodeAnalysis;

namespace Ejercicio_5
{
    public class Program
    {
        public static void Main()
        {
            int pos = 5;
            Console.WriteLine(numerofibonacci(pos));
        }
        
        public static int numerofibonacci(int pos)
        {
            if (pos > 0)
            {
                int numero1 = 0, numero2 = 1, suma = 1;
                for (int i = 1; i < pos; i++)
                {
                    suma = numero1 + numero2;
                    numero1 = numero2;
                    numero2 = suma;
                }

                return suma;
            }
            return -1;                           
        }

    }
}