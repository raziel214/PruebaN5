using ApiProducerN5.Models.Empleados;

namespace ApiProducerN5.Interfaces
{
    public interface IEmpleadosRepository
    {
        Task<Empleados> GetByIdAsync(Guid id);
        Task<IEnumerable<Empleados>> GetAllAsync();
        Task<Empleados> CreateAsync(Empleados empleado);
        Task UpdateAsync(Empleados empleado);
    }
}
