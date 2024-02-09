using ApiProducerN5.Data;
using ApiProducerN5.Interfaces;
using ApiProducerN5.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProducerN5.Repository.RepositoryImpl
{
    public class TipoPermisosRepositoryImpl : ITipoPermisosRepository
    {
        private readonly AppDbContext _context;
        public TipoPermisosRepositoryImpl(AppDbContext context)
        {
            _context = context;
        }
        public async Task<TipoPermisos> CreateAsync(TipoPermisos tipoPermisos)
        {
            _context.TiposPermisos.Add(tipoPermisos);
            await _context.SaveChangesAsync();
            return tipoPermisos;
        }

        public async Task<IEnumerable<TipoPermisos>> GetAllAsync()
        {
            return await _context.TiposPermisos.ToListAsync();
        }

        public async Task<TipoPermisos> GetByIdAsync(Guid id)
        {
            return await _context.TiposPermisos.FindAsync(id);
        }

        public async Task UpdateAsync(TipoPermisos tipoPermisos)
        {
            _context.TiposPermisos.Update(tipoPermisos);
            await _context.SaveChangesAsync();
        }

    }
}
