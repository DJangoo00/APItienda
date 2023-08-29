using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interface;
using Infrastructure.Data;
using Infrastructure.Repository;


namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly APItiendaContext context;
        private PaisRepository _paises;
        private EstadoRepository _estados;
        public UnitOfWork(APItiendaContext _context)
        {
            _context = _context;
        }
        public IPaisInterface Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(context);
                }
                return _paises;
            }
        }
        public IRegion Regiones
        {
            get
            {
                if (_estados == null)
                {
                    _estados = new EstadoRepository(context);
                }
                return _estados;
            }
        }
        public void Dispose()
        {
            context.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
    }

}