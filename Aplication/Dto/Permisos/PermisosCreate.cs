using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto.Permisos
{
    public class PermisosCreate
    {
      
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdTipoPermiso { get; set; }
        public DateTime? FechaInicio { get; set; } // Permite valores nulos
        public DateTime? FechaFin { get; set; }
    }
}
