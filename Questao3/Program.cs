using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdeA, qtdeB;
            double valorA, valorB;

            Console.WriteLine("Digite a quantidade do produto A: ");
            qtdeA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto A: ");
            valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto B: ");
            qtdeB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto B: ");
            valorB = Convert.ToDouble(Console.ReadLine());


             double total = (qtdeA * valorA) + (qtdeB * valorB);

            Console.WriteLine("O valor total da compra foi: " + total);

        }
    }
}
