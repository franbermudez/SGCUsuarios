using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGC.Models;

namespace SGC.ViewModels
{
    public class UsuariosViewModels
    {
        public IEnumerable<Usuarios> Usuarios { get; set; }
        public IEnumerable<Niveles> Niveles { get; set; }
        public IEnumerable<Usuarios> UsuariosPorCodigo { get; set; }
    }
}
