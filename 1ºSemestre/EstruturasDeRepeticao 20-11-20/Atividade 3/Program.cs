using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double salario;
            char estadoCivil;


            do
            {
                Console.WriteLine("Digite um nome:");
                nome = Console.ReadLine();
                if(nome == "" || nome == " ")
                {
                    Console.WriteLine("Nome inválido!");
                }
            } while (nome == "" || nome == " ");

            Console.WriteLine("Nome válido!");

            do
            {
                Console.WriteLine($"{nome}, Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade <= 0 || idade >= 150)
                {
                    Console.WriteLine("Idade inválida");
                }
            } while (idade <= 0 || idade >= 150);

            Console.WriteLine("Idade Válida!");

            do
            {
                Console.WriteLine($"{nome}, Digite seu salário:");
                salario = double.Parse(Console.ReadLine());

                if (!(salario > 0))
                {
                    Console.WriteLine("Salário inválido!");   
                }

            } while (salario < 0);

            Console.WriteLine("Salário válido!");

            do
            {
                Console.WriteLine($"{nome}, Digite seu Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));");
                string estado = Console.ReadLine();
                estadoCivil = estado.ToCharArray()[0];

                if (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd' )
                {
                    Console.WriteLine("Estado civíl inválido!");
                }

            } while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd' );

            Console.WriteLine("Valores aceitos!");


        }
    }
}
