using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers.Archivos
{
    [ApiController]
    public class ObtenerIdArchivoController : ControllerBase
    {
        private readonly IArchivoRepository _archivo;

        public ObtenerIdArchivoController(IArchivoRepository archivo)
        {
            _archivo = archivo;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult ObtenerIdArchivo(int id)
        {
            return Ok(_archivo.ObtenerArchivoId(id));
        }
    }
}