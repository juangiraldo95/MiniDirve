using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers
{
    [ApiController]
    public class ObtenerIdUsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuario;

        public ObtenerIdUsuarioController(IUsuarioRepository usuario)
        {
            _usuario = usuario;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult ObtenerIdUsuario(int id)
        {
            return Ok(_usuario.ObtenerUsuarioId(id));
        }
        
    }
}