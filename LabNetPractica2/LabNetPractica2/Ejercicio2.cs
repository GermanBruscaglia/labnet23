using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Ejercicio2
    {

        public double Division(int dividendo, int divisor)
        {
                try
                {
                    double resultado = dividendo / divisor;
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
        }
}
