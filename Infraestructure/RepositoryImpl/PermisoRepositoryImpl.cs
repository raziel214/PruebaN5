using ApiProducerN5.Data;
using ApiProducerN5.Interfaces;
using ApiProducerN5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.RepositoryImpl
{
    public class PermisoRepositoryImpl:IPermisosRepository
    {
        private readonly AppDbContext _context;
        public PermisoRepositoryImpl(AppDbContext context)
        {
            _context = context;
            
        }

        public async Task<Permisos> CreateAsync(Permisos permisos)
        {
            _context.Permisos.Add(permisos);
            await _context.SaveChangesAsync();
            return permisos;
        }

        public async  Task<IEnumerable<Permisos>> GetAllAsync()
        {
           return await  _context.Permisos.ToListAsync();
        }

        public async  Task<Permisos> GetByIdAsync(Guid id)
        {
            return await _context.Permisos.FindAsync(id);
        }

        public async Task UpdateAsync(Permisos permisos)
        {
            _context.Permisos.Update(permisos);
            await _context.SaveChangesAsync();
            
        }
    }
}
