using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tarea_IV_____v.Models;




namespace Tarea_IV_____v
{
    class Listado
    {
        public void listar()
        {
            Console.Clear();

            using (MultaContext mctx = new MultaContext())
            {
                var multas = mctx.infracciones;

                foreach (Infraccion linea in multas)
                {
                    Random rnd = new Random();

                    int A = rnd.Next(0, 256);
                    int B = rnd.Next(0, 256);
                    int C = rnd.Next(0, 256);



                    Console.WriteLine("Nombre: " + linea.Nombre);
                    Console.WriteLine("Apellido: " + linea.Apellido);
                    Console.WriteLine("Cedula: " + linea.Cedula);
                    Console.WriteLine("Latitud: " + linea.Latitud);
                    Console.WriteLine("Longitud: " + linea.Longitud);
                    Console.WriteLine("Placa: " + linea.Placa);
                    Console.WriteLine("Marca: " + linea.Marca);
                    Console.WriteLine("Descripción: " + linea.Descripcion);
                    Console.WriteLine("Pagado: " + linea.Pagado);
                    Console.WriteLine("-------------------------------------------------");
                }
            }

            Console.WriteLine("Presiones enter para continuar");
            Console.ReadKey();

        }
    }
}
