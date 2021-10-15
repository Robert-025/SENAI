using System;
using AulaPOO_PolimosrfismoSobrecarga.Classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            func.Mostrar();
            func.Mostrar(3);
            func.Mostrar("Lucas");
    
        }
    }
}
