using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGC.Models
{
    public interface INiveles
    {
        IEnumerable<Niveles> ListaNiveles { get; }
    }
}
