using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string CUI { get; set; } = string.Empty;

        [Required]
        public int SucursalId { get; set; }
        
    }
}
