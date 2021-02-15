using System;
using System.Collections.Generic;
using System.Text;
using Tarea_IV_____v.Models;

namespace Tarea_IV_____v
{
    class Agregado
    {
        public void Agregar()
        {
            try
            {
                Infraccion infra = new Infraccion();

                Console.Clear();
                Console.WriteLine("Agregado de datos");


                Console.Write("Digite su cedula: ");

                infra.Cedula = Console.ReadLine();

                Console.Write("Digite su nombre: ");
                infra.Nombre = Console.ReadLine();

                Console.Write("Digite su apellido: ");
                infra.Apellido = Console.ReadLine();

                Console.Write("Digite su placa: ");
                infra.Placa = Console.ReadLine();

                Console.Write("Digite su Marca: ");
                infra.Marca = Console.ReadLine();

                Console.Write("Digite su latitud: ");
                infra.Latitud = Console.ReadLine();

                Console.Write("Digite su longitud: ");
                infra.Longitud = Console.ReadLine();

                Console.Write("Descripcion del hecho: ");
                infra.Descripcion = Console.ReadLine();

           
                infra.Pagado = false;

                Console.WriteLine("Pagado: " + infra.Pagado);


                using (MultaContext multaC = new MultaContext())
                {
                    multaC.Add(infra);
                    multaC.SaveChanges();
                }


                Console.WriteLine("Agregado con exito!!!!");
                Console.WriteLine("Presiones enter para continuar");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Realice los pasos correctamente");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
