using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, ultimoNome;
            int quartos, idade;
            double precoProduto, altura;

            Console.WriteLine("Entre com seu nome Completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            ultimoNome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}