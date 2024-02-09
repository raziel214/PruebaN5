using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto.Permisos
{
    public class ReadPermisos
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdTipoPermiso { get; set; } = Guid.Empty;
        public DateTime? FechaInicio { get; set; } 
        public DateTime? FechaFin { get; set; }
    }
}
