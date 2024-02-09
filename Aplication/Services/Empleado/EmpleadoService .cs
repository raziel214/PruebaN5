
using ApiProducerN5.Interfaces;
using ApiProducerN5.Models.Empleados;
using Aplication.Dto.Empleados;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Services.Empleado
{
    public class EmpleadoService : IEmpleadoService
    {

        private readonly IMapper _mapper;
        private readonly IEmpleadosRepository _empleadoRepository;

        public EmpleadoService(IMapper mapper, IEmpleadosRepository empleadoRepository)
        {
            _mapper = mapper;
            _empleadoRepository = empleadoRepository;
                
        }
        public async Task<ReadEmpleados> CreateAsync(EmpleadosCreate empleadoCreate)
        {
            Empleados entity = _mapper.Map<Empleados>(empleadoCreate);
            entity = await _empleadoRepository.CreateAsync(entity);
            ReadEmpleados dto = _mapper.Map<ReadEmpleados>(entity);
            return dto;
        }



        public async Task<IEnumerable<Empleados>> GetAllAsync()
        {
            return await _empleadoRepository.GetAllAsync();
        }

        public async Task<Empleados> GetByIdAsync(Guid id)
        {
            return await _empleadoRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Empleados empleado)
        {
             await _empleadoRepository.UpdateAsync(empleado);
        }

        


    }
}
