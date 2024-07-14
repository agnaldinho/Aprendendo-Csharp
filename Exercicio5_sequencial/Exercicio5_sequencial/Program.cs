using System;
/*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Entre com o código da peça o numero da peça e o valor unitário: ");
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine("2 - Entre com o código da peça o numero da peça e o valor unitário: ");
            string[] vet1 = Console.ReadLine().Split(' ');

            string codigo = vet[0];
            int numeroPeca = int.Parse(vet[1]);
            double valor = double.Parse(vet[2]);
            String codigo1 = vet1[0];
            int numeroPeca1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2]);

            double soma = (numeroPeca * valor) + (numeroPeca1 * valor1);

            Console.WriteLine("Valor a Pagar: " + soma);

        }
    }
}