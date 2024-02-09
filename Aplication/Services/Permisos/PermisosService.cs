using ApiProducerN5.Dto;
using ApiProducerN5.Interfaces;
using ApiProducerN5.Models;
using Aplication.Dto.Permisos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Services.Permiso
{
    public class PermisosService : IPermisosService
    {
        private readonly IMapper _mapper;
        private readonly IPermisosRepository _permisosRepository;

        public PermisosService(IMapper mapper, IPermisosRepository permisosRepository)
        {
            _mapper = mapper;
            _permisosRepository = permisosRepository;
            

        }

        public async Task<ReadPermisos> CreateAsync(PermisosCreate permisoCreate)
        {
            // TipoPermisos entity = _mapper.Map<TipoPermisos>(tipoPermisoCreate);
            Permisos entity =_mapper.Map<Permisos>(permisoCreate);
            entity = await _permisosRepository.CreateAsync(entity);

            ReadPermisos dto=_mapper.Map<ReadPermisos>(entity);
            return dto;
            
        }
        public  async  Task<Permisos> GetByIdAsync(Guid id)
        {
           return await _permisosRepository.GetByIdAsync(id);
        }

        public Task<IEnumerable<Permisos>> GetAllAsync()
        {
            return _permisosRepository.GetAllAsync();
        }

        

        public async Task UpdateAsync(Permisos permisos)
        {
            await _permisosRepository.UpdateAsync(permisos);
        }
    }
}
