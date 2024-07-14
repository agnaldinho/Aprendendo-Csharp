using ExercicioAula48;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual e a cotacao do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dolares voce vai comprar: ");
            double dolar = double.Parse(Console.ReadLine());

            double cotacao1 = ConversorDeMoeda.Conversor(cotacao, dolar);
            Console.WriteLine("Valor a ser pago em reais = " + cotacao1.ToString("F2"));
        }
    }
}