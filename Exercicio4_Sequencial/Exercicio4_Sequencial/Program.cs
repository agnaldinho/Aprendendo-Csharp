using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valor;

            Console.WriteLine("Numero do Funcionario: ");
            numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas trabalhadas no dia: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor que recebe por hora: ");
            valor = double.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * valor;

            Console.WriteLine(numeroFuncionario);
            Console.WriteLine(salario.ToString("F2"));
        }
    }
}