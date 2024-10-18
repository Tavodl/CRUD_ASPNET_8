using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Sucursales
    {
        [Key]
        public int SucursalId { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Direccion { get; set; } = string.Empty;
        
        [Required]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        public int EmpresaId { get; set; }
    }
}
