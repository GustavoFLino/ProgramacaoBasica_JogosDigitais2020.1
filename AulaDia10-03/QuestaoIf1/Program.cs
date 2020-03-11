using System;

namespace QuestaoIf1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("Digite o número:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 10)
            {
                Console.WriteLine("O número é maior ou igual a 10");
            }
            else
            {
                Console.WriteLine("O número é menor que 10");
            }


        }
    }

}
