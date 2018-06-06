using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SGC.Models
{
    public class NivelesRepositorios : INiveles
    {
        private readonly AppDbContext _appDbContext;


        public NivelesRepositorios(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Niveles> ListaNiveles => _appDbContext.Niveles;
        /*public IEnumerable<Niveles> Niveles
        {
            get
            {
                return _appDbContext.Niveles.Include(c => c.Nivel);
            }
        }*/
    }
}
