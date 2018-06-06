using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGC.Models
{
    public interface IUsuariosRepositorios
    {

        IEnumerable<Usuarios> Usuarios { get; }
        //envolver una gran catidad de datos con una misma similitud

        IEnumerable<Usuarios> UsuariosPorNivel { get; }
        //metodo coleccion para llamar datos con una misma caracteristica
        IEnumerable<Usuarios> UsuariosPorCodigo(int CodigoUsuario);
    }
}
