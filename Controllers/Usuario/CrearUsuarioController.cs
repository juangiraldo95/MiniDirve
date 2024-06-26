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
    public class CrearUsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuario;

        public CrearUsuarioController(IUsuarioRepository usuario)
        {
            _usuario = usuario;
        }

        [HttpPost]
        public IActionResult CrearUsuario([FromBody] Usuario usuario)
        {
            _usuario.AgregarUsuario(usuario);
            return Ok();
        }
        
    }
}