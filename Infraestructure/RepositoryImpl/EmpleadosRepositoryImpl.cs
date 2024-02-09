using ApiProducerN5.Data;
using ApiProducerN5.Interfaces;
using ApiProducerN5.Models.Empleados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.RepositoryImpl
{
    public class EmpleadosRepositoryImpl : IEmpleadosRepository
    {
        private readonly AppDbContext _context;

        public EmpleadosRepositoryImpl(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Empleados> CreateAsync(Empleados empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
            return empleado;
        }

        public async Task<IEnumerable<Empleados>> GetAllAsync()
        {
            return await _context.Empleados.ToListAsync();
        }

        public async  Task<Empleados> GetByIdAsync(Guid id)
        {
            return await _context.Empleados.FindAsync(id);
        }

        public async Task UpdateAsync(Empleados empleado)
        {
           _context.Empleados.Update(empleado);
            await _context.SaveChangesAsync();
        }
    }
}
