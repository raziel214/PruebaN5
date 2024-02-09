using ApiProducerN5.Models;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto.Empleados
{
    public class EmpleadosCreate
    {
             
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public Guid? IdTipoPermiso { get; set; }

    }
}
