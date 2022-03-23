using System;

namespace ex01_estrSeq // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            n1 = Int32.Parse(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            soma = n1 + n2;

            Console.WriteLine("A SOMA É: " + soma);
        }
    }
}