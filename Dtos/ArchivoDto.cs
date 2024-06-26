using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDriveApi.Dtos
{
    public class ArchivoDto
    {
        public int Id { get; set; }

   
        public string? Nombre { get; set; }


        public DateTime FechaCreacion { get; set; } = DateTime.Now;


        public DateTime FechaModificacion { get; set; } = DateTime.Now;


        public string? Ruta { get; set; }


        public string? Estado { get; set; }

        public int CarpetaId { get; set; }
    }
}