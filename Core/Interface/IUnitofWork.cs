using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IUnitOfWork
    {
        //
        IPaisInterface Paises { get; }
        ITipoPersona TipoPersonas { get; }
        IRegion Regiones { get; }
        Task <int> SaveAsync();
    }
}