using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            for (int i = 1; i <= 10; i++)
            {
                valor++;

                for (var n = 0; n <= 10; n++)
                {
                    int resultado = valor * n;

                    Console.WriteLine($"{valor} x {n} = {resultado}");
                }

                Console.WriteLine($"\n ");     
            
            }
            
        }
    }
}
