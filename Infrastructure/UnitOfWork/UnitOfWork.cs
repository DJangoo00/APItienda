using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interface;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork
    {
        
    }
    public UnitOfWork (APItiendaContext _context)
    {
        _context = _context;
    }
    public IPaisInterface Paises
    {}
    public IRegion Regiones
    {}
    public ITipoPersona TipoPersonas
    {}
    public void Dispose()
    {
        context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}