using ApiProducerN5.Models;

namespace ApiProducerN5.Interfaces
{
    public interface IPermisosRepository
    {
        Task<Permisos> GetByIdAsync(Guid id);
        Task<IEnumerable<Permisos>> GetAllAsync();
        Task<Permisos> CreateAsync(Permisos permisos);
        Task UpdateAsync(Permisos permisos);
    }
}
