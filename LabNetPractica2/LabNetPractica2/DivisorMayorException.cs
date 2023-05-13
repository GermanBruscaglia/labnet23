using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class DivisorMayorException : Exception
    {
        public DivisorMayorException(): base("No se puede dividir un numero por uno mayor")
        {

        }
    }
}
