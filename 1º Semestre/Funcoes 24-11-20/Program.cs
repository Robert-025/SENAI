using System;

namespace Funcoes
{
    class Program
    {

        static float CalcularMedia( float[] numeros ){

            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];

            }

            float resultado = soma / numeros.Length;

            return resultado;
        
        }

        

        static void Main( string[] args )
        {

            /* /* 1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
                    A. A Média do aluno - Função
                    B. A quantidade de Aprovados (Média >=7)
                    C. A quantidade de Reprovados (Méida < 7)
                    D. A Média geral dos 10 alunos. */ 

            string[] nomes = new string[10];
            float[] notas = new float[4];
            float[] media = new float[10];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o nome de um aluno: ");
                nomes[i] = Console.ReadLine();
                    for (int n = 0; n < notas.Length; n++)
                    {
                     Console.WriteLine($"Digite a {n+1}º nota: ");
                     notas[n] = float.Parse( Console.ReadLine() );
                     
                    }

                media[i] = CalcularMedia(notas);
                
            }

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var nomeIndividual in nomes)
            {
                // Console.WriteLine($"{nomeIndividual}");
            }

            Console.ForegroundColor = ConsoleColor. Yellow;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Nome: {nomes[i]}, Média: {media[i]}");
                
            }

            float MediaGeral = CalcularMedia( media );

            Console.WriteLine($"Media da sala: {MediaGeral}");
            
            


            }
        }
    }
