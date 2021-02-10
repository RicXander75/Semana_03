using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10 * 10;
            do
            {
                Console.WriteLine(x);
                x = x + 2;
            }
            while (x <= 120);
            {
                Console.WriteLine("Estos son los primeros 10 numeros pares a partir del producto de 10*10");
            }
        }
    }
}
