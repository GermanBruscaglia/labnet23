using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empleados");

            EmployeesLogic employesLogic = new EmployeesLogic();

            foreach(var emp in employesLogic.GetAll())
            {
                Console.WriteLine(emp.FirstName);
            }

            Console.Read();
        }
    }
}
