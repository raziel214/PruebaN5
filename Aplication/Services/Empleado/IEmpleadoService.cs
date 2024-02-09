using ApiProducerN5.Models.Empleados;
using Aplication.Dto.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services.Empleado
{
    public interface IEmpleadoService
    {
        Task<Empleados> GetByIdAsync(Guid id);
        Task<IEnumerable<Empleados>> GetAllAsync();
        Task<ReadEmpleados> CreateAsync(EmpleadosCreate empleado);
        Task UpdateAsync(Empleados empleado);
    }
}
