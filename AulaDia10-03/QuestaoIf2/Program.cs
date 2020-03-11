using System;

namespace QuestaoIf2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota = 0,media;

            Console.WriteLine("Digite seu mome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            nota += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota += Convert.ToDouble(Console.ReadLine());

            //media = calculaMedia(nota,3);
            media = nota / 3;

            if (media <= 5)
            {
                Console.WriteLine("Sua média é: " + media + "por isso você está REPROVADO");
            }
            else if((media >= 5.1) && (media <= 6.9))
            {
                Console.WriteLine("Sua média é: " + media + "por isso você está na RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("Sua média é: " + media + "por isso você está APROVADO");
            }

        }

       /* public static double calculaMedia(double nota,double quantidade)
        {
            double media = nota / quantidade;
            
            return media;
        }*/
    }
}
