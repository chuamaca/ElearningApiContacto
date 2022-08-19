using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Elearning.Models
{
    public class ContactoDto
    {

        
        public int IdContacto { get; set; }

        [Required(ErrorMessage = "The Nombre es Required")]
        public string Nombre { get; set; }
     
        public string Celular { get; set; }

        public string Direccion { get; set; }

        public string correo { get; set; }
        public int empresaId { get; set; }
 
        public Empresa Empresa { get; set; }
    }
}
