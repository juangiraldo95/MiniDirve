using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDriveApi.Models
{
    public class Archivo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string? Nombre { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required]
        public DateTime FechaModificacion { get; set; } = DateTime.Now;

        [Required]
        public string? Ruta { get; set; }

        [Required]
        public string? Estado { get; set; }

        [Required(ErrorMessage = "El campo ID del usuario es obligatorio.")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [Required(ErrorMessage = "El campo ID de la carpeta es obligatorio.")]
        public int CarpetaId { get; set; }
        public Carpeta? Carpeta { get; set; }
    }
}