using System;
using AulaPOOCelular.Classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
//      Faça em sua máquina o mesmo exemplo dado em aula.

        //  Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
        //  Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
        //  Só será possível executar tais métodos se o celular estiver ligado.
        //  Suba o projeto para um repositório no Github, com o título "AulaPOOCelular".
        //  Envie o link do repositório como entrega desta atividade.

        //Variáveis
        string resposta;
        string info;
        string fimDoPrograma;

        Celular celular1 = new Celular();

        do
        {
        Console.WriteLine($"O celular está ligado? (S/N)");
        resposta = Console.ReadLine();
        
        if (resposta.ToUpper() == "S")
        {
            celular1.ligado = true;
        }
        else if (resposta.ToUpper() == "N")
        {
            celular1.ligado = false;
            celular1.Ligar(resposta, celular1.ligado);
        }

        do
        {
        Console.WriteLine($"Digite a cor do celular: ");
        celular1.cor = Console.ReadLine();
        
        Console.WriteLine($"Digite o modelo do celular: ");
        celular1.modelo = Console.ReadLine();
        
        Console.WriteLine($"Digite quantas polegadas tem o seu celular: ");
        celular1.tamanho = Console.ReadLine();

        Console.WriteLine($"As informações do celular estão corretas? (S/N)");

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"Cor: {celular1.cor}");
        Console.WriteLine($"Modelo: {celular1.modelo}");
        Console.WriteLine($"Tamanho: {celular1.tamanho}");

        Console.ResetColor();

        info = Console.ReadLine();
            
        } while (info.ToUpper() == "N");

        Console.WriteLine($"Deseja realizar uma ligação? (S/N)");
        string realizarLigacao = Console.ReadLine();

        if (realizarLigacao.ToUpper() == "S")
        {
            celular1.ligacao = true;
            celular1.FazerLigacao(celular1.ligacao);
        }
        else if (realizarLigacao.ToUpper() == "N")
        {
            celular1.ligacao = false;
        }

        Console.WriteLine($"Deseja enviar uma mensagem? ");
        string realizarMensagem = Console.ReadLine();
        
        if (realizarMensagem.ToUpper() == "S")
        {
            celular1.mensagem = true;
            celular1.EnviarMensagem(celular1.mensagem);
        }
        else if (realizarMensagem.ToUpper() == "N")
        {
            celular1.mensagem = false;
        }

        Console.WriteLine($"O programa chegou ao fim. Deseja começar de novo? (S/N)");
        fimDoPrograma = Console.ReadLine();

        if (fimDoPrograma.ToUpper() == "S")
        {
            celular1.desligado = true;
        }
        else if (fimDoPrograma.ToUpper() == "N")
        {
            celular1.desligado = false;
            celular1.Desligar(fimDoPrograma, celular1.desligado);
        }

        } while (fimDoPrograma.ToUpper() == "S");

        }
    }
}
