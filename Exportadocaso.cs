using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tarea_IV_____v.Models;
using System.IO;
namespace Tarea_IV_____v
{

    class Exportado
    {
        public void Exportar()
        {
            Console.WriteLine("Digite el Id de la persona que desea exportar");
            int Id = int.Parse(Console.ReadLine());


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
                            "body{font-family: 'Spartan', sans-serif; display: flex; justify-content: center;   align-items: center;  height: 100vh;   background-size: contain;  background - attachment: fixed; background-image: url(https://i.pinimg.com/originals/47/0a/19/470a19a36904fe200610cc1f41eb00d9.jpg); }" +
                            "h2 span{ color: rgb(75, 75, 75);}" +
                            "h2{ font-size: 20px; color: rgb(116, 116, 116);}" +
                            "</style>" +
                            "<h1>Accidentes de transito</h1>" +
                            "<h2><span>Cedula : </span> " + cedula + "</h2>" +
                            "<h2><span>Nombre: </span> " + nombre + "</h2>" +
                            "<h2><span>Apellido : </span> " + Apellido + "</h2>" +
                            "<h2><span>Placa: </span> " + placa + "</h2>" +
                            "<h2><span>Marca: </span> " + Marca + "</h2>" +
                            "<h2><span>latitud: </span> " + latitud + "</h2>" +
                            "<h2><span>Longitud: </span> " + longitud + "</h2>" +
                            "<h2><span>Descripcion del hecho: </span> " + Descripcion + "</h2>" +
                            "<h2>-----------------------------</h2>" +
                            " </div>" +
                            "" +
                            "" +
                            "" +
                            "</body>" +
                            "</html>";

                        File.WriteAllText(ruta + "\\" + cedula + ".html", contenido);
                        }
                    }
                }
                Console.WriteLine("Exportado con exito!!!");
                Console.ReadKey();
            }
        }
    }