using System;

namespace tarea2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x=0, suma = 0;
            do
            {
                Console.WriteLine("Introduzca su numero: ");
                x = int.Parse(Console.ReadLine());
                suma = suma + x;
            } 
            while (x!=0);
            {
                Console.WriteLine("La suma de todos los numeros es: "+suma);
            }

        }
    }
} 
