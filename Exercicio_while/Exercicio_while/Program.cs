using System;

/*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            Console.WriteLine("Digite uma senha: ");
            senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha incorreta, digite novamente");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta");

            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/
            Console.WriteLine("\n\nExercicio2");
            Console.WriteLine("Digite a coordenadas x e y: ");
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            while(x != 0 && y!= 0)
            {

                if (x > 0 && y> 0) 
                {
                    Console.WriteLine("Primeiro");
                }
                else if (y > 0 && x < 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if(x < 0 && y < 0) 
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                Console.WriteLine("Digite a coordenadas x e y: ");
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }


            Console.WriteLine("\n\nExercicio3");
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
              um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
              4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
              ue seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
              mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
              exemplo*/

            int num;

            Console.WriteLine("Digite o combustivel determinado");
            num = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (num != 4)
            {
                if(num == 1) 
                {
                    alcool = alcool + 1;
                }

                else if(num == 2) 
                {
                    gasolina = gasolina + 1;
                }
                else if( num == 3) 
                {
                    diesel = diesel + 1;
                }
                Console.WriteLine("Digite o combustivel determinado");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}