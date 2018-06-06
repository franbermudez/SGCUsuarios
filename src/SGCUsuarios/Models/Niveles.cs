using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SGC.Models
{
    public class Niveles
    {
        [Key]
        public int IdNivel { get; set; }
        public string Nivel { get; set; }
        public List<Usuarios> Usuarios { get; set; }

    }
}