using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Models;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers.Archivos
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrearArchivoController : ControllerBase
    {
        private readonly IArchivoRepository _archivo;

        public CrearArchivoController(IArchivoRepository archivo)
        {
            _archivo = archivo;
        }

        [HttpPost]
        public IActionResult CrearArchivo([FromBody] Archivo archivo)
        {
            _archivo.AgragarArchivo(archivo);
            return Ok("El Archivo fue creada con exito");
        }
    }
}