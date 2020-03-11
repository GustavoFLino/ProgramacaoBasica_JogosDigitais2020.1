using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o raio da circuferencia: ");
            double raio2 = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(raio2, 2);

            Console.WriteLine("A área da circuferencia é: " + area);

        }
    }
}
