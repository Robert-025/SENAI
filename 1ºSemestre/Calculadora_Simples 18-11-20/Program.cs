using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receber a operação
            Console.WriteLine("Qual operação você deseja realizar? \nSoma, Subtracao, Multiplicacao ou Divisao");
            string operacao = Console.ReadLine().ToLower();

            //Receber o 1º número
            Console.WriteLine("Digite o 1° número: ");
            float num1 = float.Parse(Console.ReadLine());

            //Receber o 2º número
            Console.WriteLine("Digite o 2° número: ");
            float num2 = float.Parse(Console.ReadLine());

            //Realizar o cálculo
            float resultado = 0f;   //f = sulfixo do float

            switch (operacao){

                case "Soma" :
                    resultado = num1 + num2;
                    break;

                case "Subtracao" :
                    resultado = num1 - num2;
                    break;

                case "Multiplicacao" :
                    resultado = num1 * num2;
                    break;

                case "Divisao" :
                    resultado = num1 / num2;
                    break;

                default:
                    operacao = "Invalida";
                        Console.WriteLine("Operação inválida!");
                        break;
            
            }
            //Mostrar o resultado
            if(operacao != "Invalida")
            Console.WriteLine($"O resultado é: {resultado}");

        }
    }
}
