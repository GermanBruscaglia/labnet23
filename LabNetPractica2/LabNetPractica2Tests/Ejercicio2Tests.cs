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
            int num1 = 10;
            int num2 = 5;
            double resultadoEsperado = 2;
            double resultado = num1 / num2;

            Ejercicio2 divisionPrueba = new Ejercicio2();

            divisionPrueba.Division(num1 / num2);
            Assert.Fail();
        }
    }
}