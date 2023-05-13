using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    public class Ejercicio1
    {

        public static string DividePorCero(int valor)
        {
            
            try
            {
                int resultado = valor / 0;

                return $"El resultado de la division es {resultado}";
            }
            catch (DivideByZeroException ex)
            {
                return $"Error desde Ejercicio1: {ex.Message}";
            }
            catch(Exception ex)
            {
                return $"Error general: {ex.Message}";
            }
            finally
            {
                Console.WriteLine("la operacion ha finalizado");
            }
        }

    }
}
