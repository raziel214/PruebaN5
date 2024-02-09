using System.ComponentModel.DataAnnotations;
using ApiProducerN5.Models.Empleados;
namespace ApiProducerN5.Models
{
    public class TipoPermisos
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }
        public virtual ICollection<Empleados.Empleados> Empleados { get; set; }
        public virtual ICollection<Permisos> Permisos { get; set; }

    }
}
