using Lab.EF.Entities;
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
            /*Ejercicio 1 - Mostrando informacion de las entidades Territorios y Categorias*/
            //TerritoryLogic territorioLogic = new TerritoryLogic();

            //foreach (Territories item in territorioLogic.GetAll())
            //{
            //    Console.WriteLine($"{item.TerritoryDescription} - ID: {item.TerritoryID}");
            //}

            CategoriesLogic categoriesLogic = new CategoriesLogic();
            Console.WriteLine("Operaciones sobre lista de Categorias");
            Console.WriteLine();

            int operacion = 1;
            while (operacion != 5)
                {
                try
                {
                    {

                        Console.WriteLine("Eliga la operacion que desea realizar:");
                        Console.WriteLine("1 - Agregar:");
                        Console.WriteLine("2 - Borrar:");
                        Console.WriteLine("3 - Modificar:");
                        Console.WriteLine("4 - Listar categorias:");
                        Console.WriteLine("5 - Salir del programa:");
                        operacion = Int32.Parse(Console.ReadLine());

                        if (operacion > 5 || operacion < 1)
                        {
                            Console.WriteLine("ERROR:por favor ingrese uno de los valores posibles: ");
                        }

                        switch (operacion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese Nombre Categoria (Máximo 15 caracteres)");
                                string addNombre = Console.ReadLine();
                                Console.WriteLine("Ingrese descripción de la Categoría");
                                string addDescripcion = Console.ReadLine();
                                categoriesLogic.Add(new Categories
                                {
                                    CategoryName = addNombre,
                                    Description = addDescripcion
                                });
                                

                                break;
                            case 2:
                                Console.WriteLine("Ingrese ID de la Categoria que desea eliminar");
                                int deleteId = Int32.Parse(Console.ReadLine());
                                categoriesLogic.Delete(deleteId);
                                break;
                            case 3:
                                Console.WriteLine("Ingrese Nombre nuevo");
                                string updateNombre = Console.ReadLine();
                                Console.WriteLine("Ingrese Descripción nueva");
                                string updateDescripcion = Console.ReadLine();
                                Console.WriteLine("Ingrese ID de la Categoria que desea modificar");
                                int updateID = Int32.Parse(Console.ReadLine());
                                categoriesLogic.Update
                                    (new Categories
                                    {
                                        CategoryName = updateNombre,
                                        Description = updateDescripcion,
                                        CategoryID = updateID
                                    });
                                break;
                            case 4:
                                foreach (Categories item in categoriesLogic.GetAll())
                                {
                                    Console.WriteLine($"ID: {item.CategoryID} - Nombre Categoria: {item.CategoryName} - Descripción: {item.Description}");
                                }
                                break;
                        }
                    }
                }
                catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                operacion = 1;
            }
                }

                Console.WriteLine("Sale del bucle while");

            Console.Read();
        }
    }
}
