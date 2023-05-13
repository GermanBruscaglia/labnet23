using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2.Tests
{
    [TestClass()]
    public class Ejercicio2Tests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            int divisor = 5;
            int dividendo = 10;
            double resultadoObtenido = 0; 
            double resultadoEsperado = 2;

            Ejercicio2 prueba = new Ejercicio2();

            resultadoObtenido =  prueba.Division(dividendo, divisor);


            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
    }
}