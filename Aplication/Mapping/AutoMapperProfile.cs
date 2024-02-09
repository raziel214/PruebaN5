using ApiProducerN5.Dto;
using ApiProducerN5.Dto.TipoPermisos;
using ApiProducerN5.Models;
using ApiProducerN5.Models.Empleados;
using Aplication.Dto.ElasticSearchDtos;
using Aplication.Dto.Empleados;
using Aplication.Dto.Permisos;
using AutoMapper;

namespace Aplication.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PermisosCreate, Permisos>();
            CreateMap<Permisos, PermisosCreate>();
            CreateMap<Permisos, ReadPermisos>();
            CreateMap<ReadPermisos, Permisos>();
            CreateMap<Permisos, ReadPermisos>();
            CreateMap<ReadEmpleados, Empleados>();
            CreateMap<Empleados, ReadEmpleados>();
            CreateMap<EmpleadosCreate, Empleados>();
            CreateMap<Empleados, EmpleadosCreate>();
            CreateMap<TipoPermisos, TipoPermisoCreate>();
            CreateMap<TipoPermisoCreate, TipoPermisos>();
            CreateMap<TipoPermisos, ReadTipoPermisos>();
            CreateMap<ReadTipoPermisos, TipoPermisos>();
            CreateMap<Permisos, PermisoDTO>();
            CreateMap<PermisoDTO, Permisos>();
            CreateMap<PermisosCreate, PermisosDTO>();
            CreateMap<PermisoDTO, PermisosCreate>();
            
        }
    }
}
