using System;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;

            do{
                Console.WriteLine("Olá, digite uma nota entre 0 e 10: ");
                nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10 )
                {
                    Console.WriteLine("Digite um número válido");
                }
            } while (nota < 0 || nota > 10);
            Console.WriteLine("Número válido");
            
        }
    }
}
