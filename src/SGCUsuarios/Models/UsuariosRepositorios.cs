using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SGC.Models
{
    public class UsuariosRepositorios : IUsuariosRepositorios
    {
        private readonly AppDbContext _appDbContext;


        public UsuariosRepositorios(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Usuarios> Usuarios
        {
            get
            {
                return _appDbContext.Usuarios.Include(n => n.NivelUsuario);
            }
        }

        public IEnumerable<Usuarios> UsuariosPorNivel
        {
            get
            {
                return _appDbContext.Usuarios.Include(n => n.NivelUsuario).Where(u => Convert.ToBoolean(u.IdNivel));
            }
        }

        IEnumerable<Usuarios> IUsuariosRepositorios.UsuariosPorCodigo(int CodigoUsuario)
        {
            yield return _appDbContext.Usuarios.FirstOrDefault(u => u.CodigoUsuario == CodigoUsuario);
        }

    }
}
