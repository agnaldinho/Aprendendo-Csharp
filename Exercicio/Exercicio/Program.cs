using Exercicio;

Curso curso = new Curso();
Console.WriteLine("Digite a primeira nota: ");
curso.Nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
curso.Nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
curso.Nota3 = double.Parse(Console.ReadLine());


if(curso.CalcularNota() >= 60) 
{
    Console.WriteLine("Nota Final = " +  curso.Media);
    Console.WriteLine("Aprovado");
}
else 
{
    if (curso.CalcularNotaReprova() <= 30)
    {
        Console.WriteLine("Nota Final = " + curso.Media);
        Console.WriteLine("Reprovado");
        Console.WriteLine("Faltam = " + curso.Falta);
    }
}