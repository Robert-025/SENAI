using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string senha;
            
            do
            {
                Console.WriteLine("Digite o nome do usuário: ");
                username = Console.ReadLine();

                Console.WriteLine("Digite uma senha");
                senha = Console.ReadLine();
                if (username == senha)
                {
                    Console.WriteLine("O nome do usuário não pode ser igual a senha.");
                }
            } while (username == senha);
            Console.WriteLine("Nome do usuário e senha válidos");
        }
    }
}
