using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int soma = 0;

            for (int i = 0; i < 5; i++)
            {
             
                Console.WriteLine("Digite o número: ");
                soma += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("O Resultado da soma dos valores é: " + soma);*/


            
            int soma = 0;

            Console.WriteLine("Digite o primeiro número:");
            soma += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            soma += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            soma += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o quarto número:");
            soma += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o quinto número:");
            soma += Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O resultado é: " + soma);
        }
    }
}
