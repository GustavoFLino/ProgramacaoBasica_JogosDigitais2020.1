using System;

namespace MultiplicaDoisValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, multp;

            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            multp = num1 * num2;

            Console.WriteLine("O Resultado é: " + multp);
        }
    }
}
