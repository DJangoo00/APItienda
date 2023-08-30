using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Core.Entities;
using Core.Interface;
using Infrastructure.Data;

namespace Infrastructure.Repository;


public class PaisRepository : GenericRepository<Pais>, IPaisInterface
{
    private readonly APItiendaContext _context;
    public PaisRepository(APItiendaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .ToListAsync();
    }
    public override async Task<Pais> GetByIdAsync(int id)
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}