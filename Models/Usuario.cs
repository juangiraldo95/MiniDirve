
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace MiniDriveApi.Models
{
    public class Usuario
    {
    
        public int Id { get; set; }

      
        public string? Nombres { get; set; }

        
        public string? Apellidos { get; set; }

        [Required(ErrorMessage = "El campo Correo del usuario es obligatorio.")]
        public string? Correo { get; set; }

        [Required]
        public string? Contrasena { get; set; }
        [JsonIgnore]
        public List<Carpeta>? Carpetas { get; set;}

    }
}