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
            double pi = 3.14159;
            double raio;

            Console.WriteLine("Digite a medida do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A área do círculo é: {0:F4}", raio * pi);
        }

        public void ex3()
        {
            int codigoItem, qtdItem;

            // int codCachQuente = 1, codXsalada = 2, codXbacon = 3,
            //    codTorradaSimples = 4, codRefrigerante = 5;

            double precoCachQuente = 4, precoXsalada = 4.5, precoXbacon = 5,
                precoTorradaSimples = 2, precoRefrigerante = 1.5, precoTotal;

            Console.WriteLine("Digite um código de item: ");
            codigoItem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma quantidade de item: ");
            qtdItem = int.Parse(Console.ReadLine());

            switch (codigoItem)
            {
                case 1:
                    precoTotal = qtdItem * precoCachQuente;
                    Console.WriteLine("PRECO TOTAL: " + precoTotal);
                    break;

                case 2:
                    precoTotal = qtdItem * precoXsalada;
                    Console.WriteLine("PRECO TOTAL: " + precoTotal);
                    break;

                case 3:
                    precoTotal = qtdItem * precoXbacon;
                    Console.WriteLine("PRECO TOTAL: " + precoTotal);
                    break;

                case 4:
                    precoTotal = qtdItem * precoTorradaSimples;
                    Console.WriteLine("PRECO TOTAL: " + precoTotal);
                    break;

                case 5:
                    precoTotal = qtdItem * precoRefrigerante;
                    Console.WriteLine("PRECO TOTAL: " + precoTotal);
                    break;

                default:
                    Console.WriteLine("VALOR INVÁLIDO !");
                    break;
            }
        }

        public void ex4()
        {
            double a, b, c, delta, raiz1, raiz2;

            Console.WriteLine("Digite um valor para o coeficiente A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para o coeficiente B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para o coeficiente C: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = (b * b) - 4 * a * c;

            if (delta < 0)
                Console.WriteLine("IMPOSSÍVEL CALCULAR");
            else if (delta == 0) {
                raiz1 = -b / (2 * a);
                Console.WriteLine("A equação possui apenas uma raiz: " + raiz1);
            } else
            {
                raiz1 = (b * -1) + Math.Sqrt(delta) / 2 * a;
                raiz2 = (b * -1) - Math.Sqrt(delta) / 2 * a;

                Console.WriteLine("A equação possui duas raízes \n");
                Console.WriteLine("A primeira raiz tem valor: " + raiz1);
                Console.WriteLine("A segunda raiz tem valor: " + raiz2);
            }
        }
    }
}