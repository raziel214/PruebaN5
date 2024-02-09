using ApiProducerN5.Models;

namespace ApiProducerN5.Interfaces
{
    public interface ITipoPermisosRepository
    {
        Task<TipoPermisos> GetByIdAsync(Guid id);
        Task<IEnumerable<TipoPermisos>> GetAllAsync();
        Task<TipoPermisos> CreateAsync(TipoPermisos tipoPermisos);
        Task UpdateAsync(TipoPermisos tipoPermisos);
    }
}
