using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers.Archivos
{
    [ApiController]
    public class EliminarArchivoController : ControllerBase
    {
        private readonly IArchivoRepository _archivo;

        public EliminarArchivoController(IArchivoRepository archivo)
        {
            _archivo = archivo;
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult EliminarArchivo(int id)
        {
            _archivo.EliminarArchivo(id);
            return Ok("Archivo Eliminada con exito");
        }


    }
}