using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/
            Console.WriteLine("Exercicio1");
            int numero;
            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            Console.WriteLine("\nExercicio2");
            Console.WriteLine("Digite um número: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero2 % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            Console.WriteLine("\nExercicio3");

            int a, b;

            Console.WriteLine("Digite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            b = int.Parse(Console.ReadLine());

            if (a % b == 0 && b % a == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não multiplos");
            }

            Console.WriteLine("\nExercicio4");
            Console.WriteLine("Digite a hora inicial e final: ");
            string[] vet = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            if (horaInicial < horaFinal)
            {
                int soma = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + soma + "HORA(S)");
            }
            else
            {
                int soma = 24 - horaInicial + horaInicial;
                Console.WriteLine("O JOGO DUROU " + soma + "HORA(S)");
            }

            Console.WriteLine("\nExercicio5");
            int codigo;
            double item, cachorroQuente = 4, xSalada = 4.50, xBacon = 5, torrada = 2, refrigente = 1.50;

            Console.WriteLine("Entre com o codigo do produto e valor: ");
            string[] vet3 = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet3[0]);
            item = double.Parse(vet3[1]);


            if (codigo == 1)
            {
                double soma = item * cachorroQuente;
                Console.WriteLine("Total: " + soma);
            }
            else if (codigo == 2)
            {
                double soma = item * xSalada;
                Console.WriteLine("Total: " + soma);
            }
            else if (codigo == 3)
            {
                double soma = item * xBacon;
                Console.WriteLine("Total: " + soma);
            }
            else if (codigo == 4)
            {
                double soma = item * torrada;
                Console.WriteLine("Total: " + soma);
            }
            else if (codigo == 5)
            {
                double soma = item * refrigente;
                Console.WriteLine("Total: " + soma);
            }
            else
            {
                Console.WriteLine("Codigos de 1 a 5");
            }

            Console.WriteLine("\nExercicio6");
            double intervalo;
            Console.WriteLine("Digite um numero: ");
            intervalo = int.Parse(Console.ReadLine());

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (intervalo <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(intervalo <=50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (intervalo <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else 
            {
                Console.WriteLine("Intervalo (75,100]");   
             }

            Console.WriteLine("\nExercicio7");
            double x1, y1;

            Console.WriteLine("Entre com o valor x: ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor y: ");
            y1 = int.Parse(Console.ReadLine());

            if (x1 == 0.0 && y1 == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x1 == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y1 == 0.0)
            {
                Console.WriteLine("Eixo X");
            }

            else if (x1 >= 0 && y1 >= 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x1 < 0 && y1 >= 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x1 < 0 && y1 < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Console.WriteLine("\nExercicio8");

            double salario1;

            Console.WriteLine("Entre com o salario: ");
            salario1 = double.Parse(Console.ReadLine());

            if(salario1 <= 2000)
            {
                Console.WriteLine("ISENTO");
            }
            else if (salario1 <= 3000)
            {
                double soma = salario1 * 0.08;
                Console.WriteLine(soma);
            }
            else if(salario1 <= 4500)
            {
                double soma = salario1 * 0.18;
                Console.WriteLine(soma);
            }
            else 
            {
                double soma = salario1 * 0.28;
                Console.WriteLine(soma);
            }
        }
    }
}