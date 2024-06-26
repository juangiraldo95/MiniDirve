using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers
{
    [ApiController]
    public class EliminarCarpetaController : ControllerBase
    {
        private readonly ICarpetaRepository _carpeta;

        public EliminarCarpetaController(ICarpetaRepository carpeta)
        {
            _carpeta = carpeta;
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult EliminarCarpeta(int id)
        {
            _carpeta.EliminarCarpeta(id);
            return Ok("Carpeta Eliminada con exito");
        }

    }
}