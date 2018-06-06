using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGC.Models
{
    public class Usuarios
    {
        [Key]
        public int CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidosUsuario { get; set; }
        public int IdNivel { get; set; }
        public string CuentaUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public virtual Niveles NivelUsuario { get; set; }
    }
}
