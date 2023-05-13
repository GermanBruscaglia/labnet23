using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    internal class Logic
    {
        public string LanzarException(int num1, int num2)
        {
            if(num2 < num1)
            {
                try
                {
                    int resultado = num1 / num2;

                    return $"El resultado es {resultado}";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new DivisorMayorException();
            }

        }

        
    }
}
