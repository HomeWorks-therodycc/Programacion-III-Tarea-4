using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tarea_IV_____v.Models
{
    class Infraccion
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Latitud { get; set; }
        [Required]
        public string Longitud { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Pagado { get; set; }

    }
}
