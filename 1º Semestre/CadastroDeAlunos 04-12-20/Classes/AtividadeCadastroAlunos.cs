using System;

namespace CadastroDeAlunos.Classes
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public double mediaFinal;
        public double valorDaMensalidade;

        //Métodos
        public void VerMediaFinal(double media){
            Console.WriteLine($"A média do aluno é: {media}");
            
        }

        public void VerMensalidade(bool bolsista, double mensalidade){
            if (bolsista == true)
            {
                Console.WriteLine($"Este aluno tem bolsa");
                Console.WriteLine($"Valor da mensalidade sem o desconto: R${mensalidade}");
                Console.WriteLine($"Valor da mensalidade com o desconto: R${mensalidade * 0.7}");
                

            }else{
                Console.WriteLine($"Este aluno NÃO tem bolsa");
                Console.WriteLine($"Valor da mensalidade: R${mensalidade}");
                
        
            }
        }
    }
}