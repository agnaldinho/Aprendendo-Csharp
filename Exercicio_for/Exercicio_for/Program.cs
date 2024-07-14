using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.*/
            Console.WriteLine("Exercicio1");
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i < numero; i++)
            {
                if(i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\n\nExercicio2");
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
            int numero1, in1 = 0, out1 = 0;
            Console.WriteLine("Digite a quantidade de numeros: ");
            numero1 = int.Parse(Console.ReadLine());

            for (int j = 1;j <= numero1; j++) 
            {
                Console.WriteLine("{0} - Digite o numero: ", j);
                int valor = int.Parse(Console.ReadLine());

                if(valor <= 10 && valor <= 20) 
                {
                    in1 += 1;
                }
                else 
                {
                    out1 += 1;
                }
            }
            Console.WriteLine("{0} in", in1);
            Console.WriteLine("{0} out", out1);

            Console.WriteLine("\n\nExercicio3");
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
peso 5.*/

            Console.WriteLine("");
        }
    }
}