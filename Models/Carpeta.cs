
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace MiniDriveApi.Models
{
    public class Carpeta
    {
        
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public DateTime FechaModificacion { get; set; } = DateTime.Now;

        [Required]
        public string? Ruta { get; set; }

        [Required]
        public string? Estado { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        [JsonIgnore]
        public List<Archivo>? Archivos { get; set; }

    }
}