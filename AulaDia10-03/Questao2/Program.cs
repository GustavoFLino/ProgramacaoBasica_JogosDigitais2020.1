using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            double notas = 0;
            
            Console.WriteLine("Digite a primeira nota: ");
            notas += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            notas += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            notas += Convert.ToDouble(Console.ReadLine());

            double media = notas / 3;

            Console.WriteLine("A média do aluno é: " + media);



        }
    }
}
