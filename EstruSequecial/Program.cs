using System;

namespace EstruSequecial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncio, hrsTrab;
            double valorHr, calcSalario;

            Console.WriteLine("Digite o  numero do funcionario: \n");
            numFuncio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas: \n");
            hrsTrab = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora: \n");
            valorHr = doule.Parse(Console.ReadLine());
            Console.WriteLine("Seu salário será de: \n");
            calcSalario = double.Parse(Console.ReadLine());
            
            calcSalario = hrsTrab * valorHr;
            Console.WriteLine("O salário do funcionario {1} é de {0:F2}: ", numFuncio, calcSalario);

        }
    }
}
