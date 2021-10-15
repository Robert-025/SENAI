using System;
using AulaPOO_Heranca.Classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando sublcasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();

            pf.nome = "Robert";
            
            pf.cpf = "123.456.789-00";
             
            pf.rg = "12.345.678-9";

            //Chamando método de saudação
            Console.WriteLine($"{pf.DarBoasVindas( pf.nome )}");
             
            //Chamando método de validação de CPF
            Console.WriteLine($"{pf.ValidarCPF( pf.cpf )}");
             

            System.Threading.Thread.Sleep(3000);

            //Instanciando subclasse PessoaJuridica
            PessoaJuridica pj = new PessoaJuridica();

            pj.cnpj = "12.345.678/1234-56";

            pj.inscricaoEstadual = "01.234.5678-9";

            //Chamando método de validação de CNPJ
            Console.WriteLine($"{pj.ValidarCNPJ( pj.cnpj )}");
            




        }
    }
}
