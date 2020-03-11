using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome, sobrenome;

            Console.WriteLine("Digite o seu primeiro nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            string nomeCompleto = nome + " " +  sobrenome;

            Console.WriteLine("Seu nome completo é: " + nomeCompleto);
        }
    }
}
