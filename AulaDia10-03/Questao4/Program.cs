using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            double horasTrabalhadas, valorHora, percentualDesconto;

            Console.WriteLine("Digite a quantidade de horas trabalhadas no mes: ");
            horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora: ");
            valorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o percentual de desconto(em %)");
            percentualDesconto = Convert.ToDouble(Console.ReadLine());

            double salarioBruto = horasTrabalhadas * valorHora;
            double totalDesconto = (percentualDesconto / 100.0) * salarioBruto;
            double salarioLiquido = salarioBruto - totalDesconto;

            Console.WriteLine("A quantidade de horas trabalhadas foi: " + horasTrabalhadas);
            Console.WriteLine("Logo, o salário bruto é de: " + salarioBruto);
            Console.WriteLine("Aplicando o desconto de " + percentualDesconto + "%, temos " + totalDesconto + "de desconto no salário");
            Console.WriteLine("Resultando num salário liquido de: " + salarioLiquido);

        }
    }
}
