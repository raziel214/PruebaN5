using ApiProducerN5.Dto.TipoPermisos;
using ApiProducerN5.Dto;
using ApiProducerN5.Models;

namespace ApiProducerN5.Services.TiposPermisos
{
    public interface ITiposPermisosService
    {
        Task<TipoPermisos> GetByIdAsync(Guid id);
        Task<IEnumerable<TipoPermisos>> GetAllAsync();
        Task<ReadTipoPermisos> CreateAsync(TipoPermisoCreate tipoPermisoCreate);
        Task UpdateAsync(TipoPermisos tipoPermisos);
    }
}
