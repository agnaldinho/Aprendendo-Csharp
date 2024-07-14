using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Entre com o numero 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero 3: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero 4: ");
            d = int.Parse(Console.ReadLine());

            int diferenca = (a*b-c*d);

            Console.WriteLine(diferenca);
        }
    }
}