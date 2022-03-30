namespace EstruSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, numPeca1, codPeca2, numPeca2;
            double valorPeca1, valorPeca2, valorTotal;

            Console.WriteLine("Digite o codigo da peça 1: ");
            codPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de peças 1: ");
            numPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario de peças 1: ");
            valorPeca1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o codigo da peça 2: ");
            codPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de peças 2: ");
            numPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario de peças 2: ");
            valorPeca2 = double.Parse(Console.ReadLine());

            valorTotal = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);
            Console.WriteLine("O valor total a ser pago é: " + valorTotal);


        }
    }
}
