using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Models;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarpetasController : ControllerBase
    {
        private readonly ICarpetaRepository _carpeta;

        public CarpetasController(ICarpetaRepository carpeta)
        {
            _carpeta = carpeta;
        }
        
        [HttpGet]
        public IEnumerable<Carpeta> GetCarpetas(){
            return _carpeta.ObtenerCarpetas();
        }

    }
}