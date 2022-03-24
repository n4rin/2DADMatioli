using System;

namespace ex02_estrSeq // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            raio = Convert.ToInt32(Console.ReadLine());
            area = 3.141519*(raio*raio);

            Console.WriteLine("A área do círculo é: {0:0.0000}", area);
        }
    }
}