using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Omnibus> listaOmnibus = new List<Omnibus>();

            //for (var i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Cantidad de pasajeros Omnibus{i}");
            //    listaOmnibus.Add(new Omnibus(Int32.Parse(Console.ReadLine()), $"Omnibus{i}"));
            //}

            string prueba = "12345";
            int pruebaSalida;
            int.TryParse(prueba, out pruebaSalida);

            Console.WriteLine($"prueba: {prueba} - pruebaSalida: {pruebaSalida}");

            //List<Taxi> listaTaxi = new List<Taxi>();

            //for (var i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Cantidad de pasajeros Taxi{i}");
            //    listaTaxi.Add(new Taxi(Int32.Parse(Console.ReadLine()), $"Taxi{i}"));
            //}


            //Console.Clear();
            //Console.WriteLine("Lista de pasajeros de Omnibus");
            //foreach (var item in listaOmnibus)
            //{
            //    Console.WriteLine(item.Listarvehivulos());
            //}

            //Console.WriteLine("Lista de pasajeros de Taxi");
            //foreach (var item in listaTaxi)
            //{
            //    Console.WriteLine(item.Listarvehivulos());
            //}

            Console.Read();





            //        //Coche coche1 = new Coche();

            //        //Coche coche2 = new Coche();

            //        //Console.WriteLine(coche1.GetInfoCoche());

            //        //Coche coche3 = new Coche(4500.5, 1.2);
            //        //Console.WriteLine(coche3.GetInfoCoche());
            //        Console.Read();
            //    }
            //}

            //class Coche
            //{

            //    public Coche()
            //    {
            //        ruedas = 4;
            //        largo = 2300.5;
            //        ancho = 0.800;
            //    }

            //    public Coche(double anchoCoche, double largoCoche)
            //    {
            //        ruedas = 4;
            //        largo = largoCoche;
            //        ancho = anchoCoche;
            //    }

            //    public string GetInfoCoche()
            //    {
            //        return $"Informacion del coche: - {ruedas} - {largo} - {ancho}";
            //    }

            //    private int ruedas;

            //    private double ancho;

            //    private double largo;

            //    private bool climatizador;

            //    private string tapizeria;



        }

    }
}
