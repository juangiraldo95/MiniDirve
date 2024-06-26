using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Models;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers.Archivos
{
    [ApiController]
    public class ActualizarArchivoController : ControllerBase
    {
        private readonly IArchivoRepository _archivo;

        public ActualizarArchivoController(IArchivoRepository archivo)
        {
            _archivo = archivo;
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult ActualizarArchivo(int id, [FromBody] Archivo archivo)
        {

            var archivoExistente = _archivo.ObtenerArchivoId(id);
            if (archivo == null)
            {
                return NotFound();
            }
            archivoExistente.Id = archivo.Id ;
            archivoExistente.Nombre = archivo.Nombre;
            archivoExistente.Ruta = archivo.Ruta;
            archivoExistente.Estado = archivo.Estado;
            archivoExistente.CarpetaId = archivo.CarpetaId;

            _archivo.ActualizarArchivo(archivoExistente);
            return Ok("archivo actualizado correctamente");
        }
    }
}