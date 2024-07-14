using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double pi = 3.14159;

            Console.WriteLine("Entre com o numero: ");
            raio = double.Parse(Console.ReadLine());

            double area = pi * (raio * raio);

            Console.WriteLine(area.ToString("F4"));
            
        }
    }
}