using ApiProducerN5.Models;
using Aplication.Dto.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services.Permiso
{
    public interface IPermisosService
    {
        Task<Permisos> GetByIdAsync(Guid id);
        Task<IEnumerable<Permisos>> GetAllAsync();
        Task<ReadPermisos> CreateAsync(PermisosCreate permisoCreate);
        Task UpdateAsync(Permisos permisos);
    }
}
