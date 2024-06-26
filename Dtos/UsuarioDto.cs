
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace MiniDriveApi.Dtos
{
    public class UsuarioDto
    { 
        public string? Correo { get; set; }

        public string? Contrasena { get; set; }
    }
}