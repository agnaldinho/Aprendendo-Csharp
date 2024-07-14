using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula48
{
    internal class ConversorDeMoeda
    {
        static public double Conversor(double valor, double valor2) 
        {
            return valor * valor2 + (valor * valor2 / 100.0) * 6.0;
        }
    }
}
