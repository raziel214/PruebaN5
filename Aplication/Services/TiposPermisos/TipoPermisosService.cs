using ApiProducerN5.Dto;
using ApiProducerN5.Dto.TipoPermisos;
using ApiProducerN5.Interfaces;
using ApiProducerN5.Models;
using ApiProducerN5.Services.TiposPermisos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProducerN5.Services
{
    public class TipoPermisosService : ITiposPermisosService
    {
        private readonly IMapper _mapper;
        private readonly ITipoPermisosRepository _tipoPermisosRepository;

        public TipoPermisosService(IMapper mapper, ITipoPermisosRepository tipoPermisosRepository)
        {
            _mapper = mapper;
            _tipoPermisosRepository = tipoPermisosRepository;
        }

        public async Task<ReadTipoPermisos> CreateAsync(TipoPermisoCreate tipoPermisoCreate)
        {
            TipoPermisos entity = _mapper.Map<TipoPermisos>(tipoPermisoCreate);
            entity = await _tipoPermisosRepository.CreateAsync(entity);

            ReadTipoPermisos dto = _mapper.Map<ReadTipoPermisos>(entity);
            return dto; // Retorna el DTO mapeado
        }

        public async Task<IEnumerable<TipoPermisos>> GetAllAsync()
        {
            return await _tipoPermisosRepository.GetAllAsync();
        }

        public async Task<TipoPermisos> GetByIdAsync(Guid id)
        {
            return await _tipoPermisosRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(TipoPermisos tipoPermisos)
        {
            await _tipoPermisosRepository.UpdateAsync(tipoPermisos);
           
        }

       
    }
}
