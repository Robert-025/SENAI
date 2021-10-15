using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Entrada
                    receber o nome do produto
                    receber o preco da unidade
                    receber a quantidade adquirida
                    receber o desconto
                    
                Processamento
                    Calcular o total sem desconto
                    calcular o desconto
                    calcular o total a pagar
                    
                Saída
                    Escrever o total sem desconto
                    escrever o total a se pagar (com desconto)  */

            Console.WriteLine($"Olá, digite a descrição (nome) do produto: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine($"Quantas unidades você comprou? ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o preço do(a) {nome}?");
            float preco = float.Parse(Console.ReadLine());

            float TotalAPagar = totalAPagar(nome,quantidade,preco);
            
            float totalAPagar(string nome, int quantidade, float preco){

                float precoBruto = quantidade * preco;
                float desconto;

                if (quantidade <= 5)
                {
                    desconto = 0.02f;

                }else if (quantidade <= 10)
                {
                    desconto = 0.03f;

                }else
                {
                    desconto = 0.05f;
                    
                }

                float valorDesconto = precoBruto * desconto;
                float valoraSerPago = precoBruto - valorDesconto;

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Sua compra ficou R${precoBruto}");
                Console.WriteLine($"O total do desconto é R${valorDesconto}");
                Console.WriteLine($"Sua compra com desconto ficou R${valoraSerPago}");

            return precoBruto;
            }
            
            
                
                


            
            
            
                
        }
    }
}
