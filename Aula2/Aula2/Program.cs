using System;

namespace MyApp // Observação: o namespace real depende do nome do projeto.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lê a frase fornecida pelo usuário
            string frase = Console.ReadLine();

            // Lê os valores de x, y e z fornecidos pelo usuário
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            // Divide a string em um array de strings usando o espaço como separador
            string[] vet = Console.ReadLine().Split(' ');

            // Atribui os valores do array a, b e c
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            // Imprime os valores lidos
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
