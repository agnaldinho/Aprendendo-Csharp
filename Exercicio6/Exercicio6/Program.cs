using System;

/*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.*/




namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi = 3.14159;

            Console.WriteLine("Entre com o valor A, B e C");
            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            double area = (A * C) / 2;
            double circulo = pi * (C*C);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("Triangulo " + area.ToString("F3"));
            Console.WriteLine("circulo " + circulo.ToString("F3"));
            Console.WriteLine("trapezio " + trapezio.ToString("F3"));
            Console.WriteLine("quadrado " + quadrado.ToString("F3"));
            Console.WriteLine("retangulo " + retangulo.ToString("F3"));


        }
    }
}