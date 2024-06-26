using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Dtos;
using MiniDriveApi.Models;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers
{
    [ApiController]
    public class ActualizarCarpetaController : ControllerBase
    {
        private readonly ICarpetaRepository _Carpeta;

        public ActualizarCarpetaController(ICarpetaRepository carpeta)
        {
            _Carpeta = carpeta;
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult ActualizarCarpeta(int id, [FromBody] Carpeta carpeta)
        {

            var CarpetaDto = new CarpetaDto();

            

            var carpetaExistente = _Carpeta.ObtenerCarpetaId(id);
            if (carpeta == null)
            {
                return NotFound();
            }
            carpetaExistente.Id = carpeta.Id ;
            carpetaExistente.Nombre = carpeta.Nombre;
            carpetaExistente.FechaCreacion = carpeta.FechaCreacion;
            carpetaExistente.Ruta = carpeta.Ruta;
            carpetaExistente.Estado = carpeta.Estado;
            carpetaExistente.UsuarioId = carpeta.UsuarioId;

            _Carpeta.ActualizarCarpeta(carpetaExistente);
            return Ok("Carpeta actualizado correctamente");
        }
    }
}