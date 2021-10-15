using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Qual o combústível desejado? ");
            string tipoCombustivel = Console.ReadLine();

            Console.WriteLine("Quantos litros de combustível você deseja?");
            float litros = float.Parse(Console.ReadLine());

            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f; 

            Console.ForegroundColor = ConsoleColor.Green;

            switch (tipoCombustivel.ToLower())
            {
                case "a":

                        Console.WriteLine($"O valor a ser pago é: {valorASerPago(litros, precoAlcool, 0.03f, 0.05f)}");

                    break;

                case "g":

                    Console.WriteLine($"O valor a ser pago é: {valorASerPago(litros, precoGasolina, 0.04f, 0.06f)}");

                    break;

                default:
                    Console.WriteLine($"Valor inválido");
                    break;
            } //Fim switch

            static float valorASerPago(float litros, float preco, float desc1, float desc2){

                float descontoPercentual;

                if(litros <= 20){
                
                    descontoPercentual = desc1;
                    
                }else{
                
                    descontoPercentual = desc2;
                    
                }
                float descontoTotal = (litros * preco) * descontoPercentual;
                float precoBruto = litros * preco;
                float valorAPagar = precoBruto - descontoTotal;

                return valorAPagar;
            }
            
        }
    }
}
