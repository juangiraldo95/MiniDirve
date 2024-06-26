
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace MiniDriveApi.Dtos
{
    public class CarpetaDto
    {
        
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
        public string? Ruta { get; set; }
        public string? Estado { get; set; }
        public int UsuarioId { get; set; }


    }
}