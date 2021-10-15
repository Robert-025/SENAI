using System;

namespace LacosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o número que você deseja ver a tabuada? ");
            int resposta = int.Parse(Console.ReadLine());

            for(int contador = 0; contador <= 10; contador++){
            
            int resultado = resposta * contador;

                Console.WriteLine($"{resposta} x {contador} = {resultado} ");
            }

            
        }
    }
}
