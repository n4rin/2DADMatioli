using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaDiagnostica
{ 
    class Solucao
    {
        public void ex1()
        {
            int cp1, qp1;
            float pu1;
            int cp2, qp2;
            float pu2, vlrPagar;

            Console.WriteLine("Exercício 1 !!\n");
            Console.WriteLine("Digite o código da peça 1: \n");
            cp1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a qtd da peça 1: \n");
            qp1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário da peça 1: \n");
            pu1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da peça 2: \n");
            cp2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a qtd da peça 2: \n");
            qp2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário da peça 2: \n");
            pu2 = float.Parse(Console.ReadLine());

            vlrPagar = (qp1 * pu1) + (qp2 * pu2);
            Console.WriteLine("O valor a pagar é -> {0:F2}: ", vlrPagar);
        }
        public void ex2()
        {
            Console.WriteLine("Exercício 2 !!\n");
        }
    }
}
