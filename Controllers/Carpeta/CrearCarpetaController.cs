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
    [Route("api/[controller]")]
    public class CrearCarpetaController : ControllerBase
    {
        private readonly ICarpetaRepository _carpeta;

        public CrearCarpetaController(ICarpetaRepository carpeta)
        {
            _carpeta = carpeta;
        }

        [HttpPost]
        public IActionResult CrearCarpeta([FromBody] Carpeta carpeta)
        {
            _carpeta.AgregarCarpeta(carpeta);
            return Ok("Carpeta creada con exito" + carpeta);
        }


    }
}