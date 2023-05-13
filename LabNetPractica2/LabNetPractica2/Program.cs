using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1*/
            //int valor;
            //string n;
            //bool esNumero;
            //do
            //{
            //    Console.WriteLine("Ingrese Valor Entero, solo se aceptan numeros");
            //    n = Console.ReadLine();
            //    /* Si es número correcto retornará true y saldrá
            //         del Ciclo*/
            //    esNumero = int.TryParse(n, out valor);
            //}
            //while (!esNumero);

            //Console.WriteLine(Ejercicio1.DividePorCero(valor));

            /*Ejercicio 2*/

            //try
            //{
            //    Console.WriteLine("Ingrese un numero a dividir");
            //    int dividendo = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese un numero divisor");
            //    int divisor = Int32.Parse(Console.ReadLine());

            //    Ejercicio2 prueba = new Ejercicio2();

            //    Console.WriteLine("El resultado de la division es: " + prueba.Division(dividendo, divisor));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"{ex.Message}: - Solo Chuck Norris puede dividir por cero");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(  "Seguro ingreso una letra o no ingreso nada");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("La operacion ha finalizado");
            //}

            /*Ejercicio 3*/

            //Logic ejercicio3 = new Logic();

            //try
            //{
            //    Console.WriteLine(ejercicio3.LanzarException(10,5));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Mensaje de Excepcion: {ex.Message}");
            //    Console.WriteLine($"Tipo de Excepcion: {ex.GetType()}");
            //}

            Logic ejercicio4 = new Logic();

            try
            {
                Console.WriteLine(ejercicio4.LanzarException(10,2));
            }
            catch (DivisorMayorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        
        }
    }
}
