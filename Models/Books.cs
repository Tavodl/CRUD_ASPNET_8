using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Empresas
    {
        [Key]
        public int EmpresaId { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Pais { get; set; } = string.Empty;
    }
}
