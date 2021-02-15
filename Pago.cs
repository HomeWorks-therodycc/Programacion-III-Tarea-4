using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tarea_IV_____v.Models;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace Tarea_IV_____v
{

    class Pagar
    {
        Infraccion infra = new Infraccion();
        public void pagar()
        {

            Console.WriteLine("Digite el Id de la persona que desea pagar");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto desea pagar?");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de la persona que està pagando?");
            string PersonPAy = Console.ReadLine();

            using (MultaContext mctx = new MultaContext())
            {


                var multas = mctx.infracciones;
                foreach (Infraccion item in multas)
                {

                    if (Id == item.Id)
                    {
                        string nombre = item.Nombre;
                        string Apellido = item.Apellido;
                        string placa = item.Placa;
                        string Descripcion = item.Descripcion;
                        string latitud = item.Latitud;
                        string longitud = item.Longitud;
                        string Marca = item.Marca;
                        string cedula = item.Cedula;

                        if (cantidad != null)
                        {
                            item.Pagado = true;
                        }
                        else 
                        {
                            item.Pagado = false;
                        }
                        mctx.SaveChanges();



                        string ruta = "C:\\Accidentes";
                        if (Directory.Exists(ruta) == false)
                        {
                            Directory.CreateDirectory(ruta);
                        }



                        string contenido = "<html>" +
                            "<head>" +
                            "<link rel='preconnect' href='https://fonts.gstatic.com'> " +
                            "<link href='https://fonts.googleapis.com/css2?family=Spartan:wght@300&display=swap' rel='stylesheet'>   " +
                        "</head>" +
                            "<body>" +
                            " <div>" +
                            "<style>" +
                            "div { background-color: rgba(240, 248, 255, 0.856); width: 400px; height: auto; box-shadow: 0 0 16px 0 rgba(0, 0, 0, 0.185);  padding: 80px;border-radius: 100px;   }" +
                            "body{font-family: 'Spartan', sans-serif; display: flex; justify-content: center;   align-items: center;  height: 100vh;   background-size: contain;  background - attachment: fixed; background-image: url(https://image.freepik.com/vector-gratis/pago-exitoso-facturas_101884-795.jpg); }" +
                            "h2 span{ color: rgb(75, 75, 75);}" +
                            "h2{ font-size: 20px; color: rgb(116, 116, 116);}" +
                            "</style>" +
                            "<h1>Factura accidente</h1>" +
                            "<h2><span>Cedula : </span> " + cedula + "</h2>" +
                            "<h2><span>Nombre: </span> " + nombre + " " + Apellido + "</h2>" +
                            "<h2><span>Persona que pagó: </span> " + PersonPAy + "</h2>" +
                            "<h2><span>Placa del vehiculo: </span> " + placa + "</h2>" +
                            "<h2><span>Marca: </span> " + Marca + "</h2>" +
                            "<h2><span>latitud: </span> " + latitud + "</h2>" +
                            "<h2><span>Longitud: </span> " + longitud + "</h2>" +
                            "<h2><span>Descripcion del hecho: </span> " + Descripcion + "</h2>" +
                            "<h2>-----------------------------</h2>" +
                            "<h2><span>Cantidad pagada: </span> " + cantidad + "</h2>" +

                            " </div>" +
                            "" +
                            "" +
                            "" +
                            "</body>" +
                            "</html>";

                        File.WriteAllText(ruta + "\\" + nombre + ".html", contenido);
                    }
                }
                Console.WriteLine("Su pago ha sido agregado con exito!!!");
                Console.ReadKey();


            }
        }
    }
}