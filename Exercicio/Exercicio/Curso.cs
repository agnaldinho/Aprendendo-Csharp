using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Curso
    {
        public double Nota1, Nota2, Nota3, Media, Falta;

        public double CalcularNota()
        {
            return Media = Nota1 + Nota2 + Nota3;
        }
        public double CalcularNotaReprova() 
        {
            return Falta = 60 - Nota1 + Nota2 + Nota3;
        }

    }
}
