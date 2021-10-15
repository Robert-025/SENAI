using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de listas com itens (arrays)
            string[] listaCompras = {"maçã", "batata", "cenoura", "banana", "laranja", "alface", "tomate", "pêra", "limão", "acucar"};
            double[] precos = { 1.5, 2.9, 3.9, 5.0, 6.0, 6.9, 7.9, 8.9, 9.9, 10.5 };

            //Criação de listas sem itens (arrays)
            string [] nomesAlunos = new string[10];




            

            for (int i = 0; i < listaCompras.Length; i++)
            {
                Console.WriteLine($"{listaCompras[i]} = R$ {precos[i]}");

            }

            for (int i = 0; i < nomesAlunos.Length; i++)
            {
                Console.WriteLine("Digite os nomes dos alunos");
                nomesAlunos[i] = Console.ReadLine();
            }
        }
    }
}
