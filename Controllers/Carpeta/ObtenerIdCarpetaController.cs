using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers
{
    [ApiController]
    public class ObtenerIdCarpetaController : ControllerBase
    {
        private readonly ICarpetaRepository _carpeta;

        public ObtenerIdCarpetaController(ICarpetaRepository carpeta)
        {
            _carpeta = carpeta;
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult ObtenerIdCarpeta(int id)
        {
            return Ok(_carpeta.ObtenerCarpetaId(id));
        }
    }
}