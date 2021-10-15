using System;

namespace _25_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine($"\nSistema de passagens \n");

            //Variáveis
            bool senhaCorreta;
            int escolha;
            int contador = 0;
            string resposta;
            //Informações da passagem
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];


            //Funções criadas
            bool FazerLogin(string senha){
                if (senha == "123456")
                {
                    Console.WriteLine($"Senha correta");
                    return true;
                }
                else{
                    Console.WriteLine($"Senha incorreta, tente novamente");
                    return false;     
                }
            }

            // Validação da senha
            do
            {
                Console.WriteLine($"Digite a senha para acessar o sistema de cadastro");
                string senha = Console.ReadLine();
                senhaCorreta = FazerLogin(senha);
                
            } while (!senhaCorreta);

            System.Threading.Thread.Sleep(1000);

            //menu
            do
            {
                
                Console.WriteLine($"Menu principal");
                Console.WriteLine($"Selecione uma das opções abaixo");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"[1] - Cadastrar passagem");
                Console.WriteLine($"[2] - Listar passagens");
                Console.WriteLine($"[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
            
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine($"Cadastrar passageiro");
                        do
                        {
                            if (contador < 5)
                            {
                                Console.WriteLine($"Digite o nome do {contador + 1} passageiro:");
                                nomes[contador] = Console.ReadLine();

                                Console.WriteLine($"Digite o destino da viagem");
                                origem[contador] = Console.ReadLine();
                            
                                Console.WriteLine($"Digite a origem da viagem");
                                destino[contador] = Console.ReadLine();
                            
                                Console.WriteLine($"Digite a data do vôo");
                                data[contador] = Console.ReadLine();
                                                        
                                contador++;
                            
                        }else
                            {
                                Console.WriteLine($"Limite de passagens excedido");
                                break;
                            
                            }
                            Console.WriteLine($"Gostaria de cadastrar outra passagem? s/n");
                            resposta = Console.ReadLine();
                        
                        } while (resposta == "s");
                        break;
                    case 2:
                        Console.WriteLine($"Listar passagens");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            
                            Console.WriteLine($"Passageiro: {nomes[i]}; destino: {destino[i]}; origem: {origem[i]} data: {data[i]}.");

                            Console.ForegroundColor = ConsoleColor.White;
                            
                        }
                    
                      break;
                    case 0:
                        Console.WriteLine($"Agradecemos a sua preferência");

                      break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        
                      break;
                }
            
            } while (escolha != 0);

        }
    }
}
