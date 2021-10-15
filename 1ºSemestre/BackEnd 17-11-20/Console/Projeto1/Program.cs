using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.Write("O resultado é: ");
            Console.WriteLine(soma);
            
        }
    }
}
