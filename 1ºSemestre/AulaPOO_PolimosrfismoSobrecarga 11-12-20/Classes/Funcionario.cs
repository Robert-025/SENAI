using System;

namespace AulaPOO_PolimosrfismoSobrecarga.Classes
{
    public class Funcionario
    {
        public string[] lista = {"Robert", "Lucas", "Pedro", "David", "lucas"};
        

        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine($"{item} \n");  
            }
        }


        public void Mostrar(int indice)
        {
            Console.WriteLine($"Busca pelo índice: {lista[indice]} \n");    
        }


        public void Mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if (item == busca)
                {
                    Console.WriteLine($"Resultado: {item}");
                    
                }
            }
        }
    }
}