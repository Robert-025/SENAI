using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("--------------------------");
            
            Console.Write(nome + ", Qual seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");
            var reajuste = 0.3 * salario;
            double salario_novo = salario + reajuste;

            if (salario < 500) 
            {
            Console.WriteLine(nome + ", Seu novo salário é: R$ " + salario_novo);
            } 
            else 
            {
            Console.WriteLine("Seu salário não atende os requisitos para ter o reajuste.");
            }
        }
    }
}
