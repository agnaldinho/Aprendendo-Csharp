using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1, soma = 0;

            Console.WriteLine("Quantos numeros inteiros voce vai digitar: ");
            numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numero; i++) 
            {
                Console.WriteLine("Digite o numero #{0}: ",i); ;
                numero1 = int.Parse(Console.ReadLine());
                soma += numero1;
            }
            Console.WriteLine("A soma dos numeros e: " +  soma);

        }
    }
}