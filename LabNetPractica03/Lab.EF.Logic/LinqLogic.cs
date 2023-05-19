using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic 
{
    public class LinqLogic : BaseLogic
    {
        /*1. Query para devolver objeto customer*/

        public string ObjetoCustomers ()
        {
            Customers objetoCostumers = context.Customers.FirstOrDefault();

            return objetoCostumers.ContactName;
        }

        /*2. Query para devolver todos los productos sin stock*/

        public List<Products> ProductosSinStock()
        {
            var productosSinStock = from productSinStock in context.Products
                                    where productSinStock.UnitsInStock == 0
                                    select productSinStock;
            return productosSinStock.ToList();
        }

        //3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad

        public List<Products> ProductosMasTres()
        {
            var productosMasTres = from productMasTres in context.Products
                                   where productMasTres.UnitPrice > 0 && productMasTres.UnitPrice > 30
                                   select productMasTres;

            return productosMasTres.ToList();   
        }

        //4. Query para devolver todos los customers de la Región WA

        public List<Customers> CustomersWA()
        {
            var customersWA = from customerWA in context.Customers
                              where customerWA.Region == "WA"
                              select customerWA;

            return customersWA.ToList();
        }

        //5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789
        public Products productID ()
        {
            var queryProductID = context.Products.Where(p => p.ProductID == 789);

            return queryProductID.FirstOrDefault();
        }

        /*6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.*/

        public List<Customers> queryCustomersMayMin()
        {
            var queryCustomer = from customerName in context.Customers
                                select customerName ;


            return queryCustomer.ToList();

        }

        //7. Query para devolver Join entre Customers y Orders donde los customers sean de la 
        //Región WA y la fecha de orden sea mayor a 1/1/1997.

        public List<DTOCustomers> JoinCustomersOrder()
        {
            var queryJoin = from c in context.Customers
                            join o in context.Orders
                            on c.CustomerID equals o.CustomerID
                            where c.Region == "WA"
                            select new DTOCustomers
                            {
                                Region = c.Region,
                                Fecha = o.OrderDate.ToString()
                            };

            return queryJoin.ToList();
        }

        //8. Query para devolver los primeros 3 Customers de la Región WA

        public List<Customers> CustomersPor3()
        {
            var queryEj8 = context.Customers.Where(c => c.Region == "wa")
                                            .Select(c => c)
                                            .ToList();
                                            
            return queryEj8;
        }

        //9. Query para devolver lista de productos ordenados por nombre

        public List<Products> ProductOrdenados()
        {
            var queryProductsOrdenados = context.Products.OrderBy(p => p.ProductName)
                                                         .Select(p => p)
                                                         .ToList();

            return queryProductsOrdenados;
        }
    }
}
