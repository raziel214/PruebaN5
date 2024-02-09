using System.ComponentModel.DataAnnotations;

namespace ApiProducerN5.Models.Empleados
{
    public class Empleados
    {

        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(255)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(255)]
        public string NumeroDocumento { get; set; }

        [Required]
        [StringLength(255)]
        public string Correo { get; set; }

        [Required]
        [StringLength(255)]
        public string Cargo { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public bool Activo { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public Guid? IdTipoPermiso { get; set; }

        public virtual TipoPermisos TipoPermiso { get; set; }

    }
}
