using System.ComponentModel.DataAnnotations;

namespace ApiProducerN5.Models
{
    public class Permisos
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public Guid? IdTipoPermiso { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }


        public virtual TipoPermisos TipoPermiso { get; set; }

       

    }
}
