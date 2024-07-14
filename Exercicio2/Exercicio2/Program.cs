using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o numero 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 2: ");
            n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("Some e: " + soma);
        }
    }
}