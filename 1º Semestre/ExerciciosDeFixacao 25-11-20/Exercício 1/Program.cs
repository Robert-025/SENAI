using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Olá, digite seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.Write($"Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            Console.ForegroundColor = ConsoleColor.Red;

            if (idade >= 16){
                
                Console.WriteLine($"Você poderá votar este ano!");
                

            }else
            {
                Console.WriteLine($"Que pena, você não pode votar este ano :(");
                
            }
            
            
        }
    }
}
