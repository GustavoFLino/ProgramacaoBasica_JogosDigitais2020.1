using System;

namespace Exercicio09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numI1, numI2;
            double numF1;

            Console.WriteLine("Digite o primeiro número inteiro: ");
            numI1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            numI2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número real: ");
            numF1 = Convert.ToDouble(Console.ReadLine());

            double resp1 = (2 * numI1) * (numI2 / 2.0);

            double resp2 = (3 * numI1) + numF1;

            double resp3 = (Math.Pow(numF1,3));

            Console.WriteLine("O Produto do Dobro de " + numI1 + "com metade de " + numI2 + " é: " + resp1);
            Console.WriteLine("A soma do triplo de " + numI1 + "+" + numF1 + "é: " + resp2);
            Console.WriteLine("O " + numF1 + "elevado ao cubo é: " + resp3);

        }
    }
}
