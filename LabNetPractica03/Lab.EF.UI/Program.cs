using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqLogic linqLogic = new LinqLogic();

            //Ejercicio 1
            //Console.WriteLine(linqLogic.ObjetoCustomers());

            //Ejercicio 2

            //foreach(var i in linqLogic.ProductosSinStock())
            //{
            //    Console.WriteLine( $"{i.ProductName} - Stock: {i.UnitsInStock}" );
            //}

            //Ejercicio 3
            //foreach(var i in linqLogic.ProductosMasTres())
            //{
            //    Console.WriteLine($"ID: {i.ProductID} - Nombre: {i.ProductName} - Stock: {i.UnitsInStock} - Precio: {i.UnitPrice}");
            //}

            //Ejercicio 4
            //foreach(var i in linqLogic.CustomersWA())
            //{
            //    Console.WriteLine($"{i.ContactName} - {i.Region}");
            //}

            //Ejercicio 5
            //Console.WriteLine(linqLogic.productID());

            //Ejercicio 6
            //foreach(var i in linqLogic.queryCustomersMayMin())
            //{
            //    Console.WriteLine(i.ContactName.ToUpper());
            //    Console.WriteLine(i.ContactName.ToLower());
            //}

            //Ejercicio 7
            //foreach(var i in linqLogic.JoinCustomersOrder())
            //{
            //    Console.WriteLine(i.Region + i.Fecha);
            //}

            //Ejericio 8
            //foreach (var i in linqLogic.CustomersPor3())
            //{
            //    Console.WriteLine(i);
            //}

            //Ejercicio 9
            //foreach (var i in linqLogic.ProductOrdenados())
            //{
            //    Console.WriteLine(i.ProductName);
            //}

            Console.Read();
        }

    }
}
