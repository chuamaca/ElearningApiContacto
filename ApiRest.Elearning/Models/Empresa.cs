using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Elearning.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        public string RasonSocila { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
    }
}
