using System;

namespace ProvaDiagnostica
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Solucao ProvaDiag = new Solucao();
            Console.WriteLine("Prova Diagnóstica!");

            ProvaDiag.ex1();
            ProvaDiag.ex2();
        }
    }
}
