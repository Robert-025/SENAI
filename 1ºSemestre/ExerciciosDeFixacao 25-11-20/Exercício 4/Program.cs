using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double[] numeros = new double[15];
            double maior = 0;
            double menor = 0;

            for (i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Insira o {i+1}º número: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }
            if (numeros.Length > 0)
            {
                maior = numeros[0];
                menor = numeros[0];
                for (i = 1; i < numeros.Length; i++)
                {
                    if (maior < numeros[i])
                    {
                        maior = numeros[i];
                    }
                    if (menor > numeros[i])
                    {
                        menor = numeros[i];
                    }
                }
            }
            else{
                Console.WriteLine($"Valores inválidos");
                
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
            
            
            Console.ReadKey();
        }
    }
}
