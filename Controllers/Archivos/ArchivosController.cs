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
    public class ArchivosController : ControllerBase
    {
        private readonly IArchivoRepository _archivo;

        public ArchivosController(IArchivoRepository archivo)
        {
            _archivo = archivo;
        }

        [HttpGet]
        public IEnumerable<Archivo> GetCarpetas(){
            return _archivo.ObtenerArchivos();
        }

    }
}