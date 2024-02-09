using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto.ElasticSearchDtos
{

    [ElasticsearchType(RelationName = "permiso")]
    public class PermisoDTO
    {
        [Keyword(Name = "id")]
        public Guid Id { get; set; }

        [Text(Name = "nombre")]
        public string Nombre { get; set; }

        [Text(Name = "descripcion")]
        public string Descripcion { get; set; }

        [Keyword(Name = "id_tipo_permiso")]
        public Guid? IdTipoPermiso { get; set; }

        [Date(Name = "fecha_inicio")]
        public DateTime? FechaInicio { get; set; }

        [Date(Name = "fecha_fin")]
        public DateTime? FechaFin { get; set; }


    }
}
