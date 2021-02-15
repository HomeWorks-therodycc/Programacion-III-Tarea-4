using System;
using Tarea_IV_____v.Models;

namespace Tarea_IV_____v
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("Violaciones de transito");
            Console.WriteLine("Agregar-----------[1]");
            Console.WriteLine("Pagar-------------[2]");
            Console.WriteLine("Exportar caso-----[3]");
            Console.WriteLine("Listado-----------[4]");

            Console.Write("Opcion a elegir: ");
            int elegir = int.Parse(Console.ReadLine());

            switch (elegir)
            {
                case 1:
                    Console.Clear();
                    Agregado add = new Agregado();
                    add.Agregar();
                    Main(args);

                    break;

                case 2:
                    Console.Clear();
                    Pagar ToPay = new Pagar();
                    ToPay.pagar();
                    Main(args);
                    break;
                case 3:
                    Exportado ToExport = new Exportado();
                    ToExport.Exportar();
                    Console.Clear();
                    Main(args);
                    break;
                case 4:
                    Console.Clear();
                    Listado list = new Listado();
                    list.listar();
                    Main(args);
                    break;
                default:
                    Console.WriteLine("Digite una opcion valida!!");
                    Console.ReadKey();
                    Main(args);
                    break;
            }
        }
    }

}
