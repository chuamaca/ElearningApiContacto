using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Elearning.Models
{
    public class Contacto
    {
        [Key]
        public int IdContacto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string correo { get; set; }
        public int empresaId { get; set; }
        [ForeignKey("empresaId")]
        public Empresa Empresa { get; set; }

    }
}
