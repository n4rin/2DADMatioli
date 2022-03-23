using System;
using System.Collections.Generic;
using System.Text;

namespace EstruSequecial
{
    class Solucao
    {
        public void ex4() 
        {
            int numFuncio, hrsTrab;
            double valorHr, calcSalario;

            {
            Console.WriteLine("Exercicio 4!!\n");
            Console.WriteLine("Digite o  numero do funcionario: \n");
            numFuncio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas: \n");
            hrsTrab = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora: \n");
            valorHr = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu salário será de: \n");
            calcSalario = double.Parse(Console.ReadLine());
            
            calcSalario = (hrsTrab * valorHr);
            Console.WriteLine("O salário do funcionario {1} é de {0:F2}: ", numFuncio, calcSalario);

            }

        }
        

    }
}
