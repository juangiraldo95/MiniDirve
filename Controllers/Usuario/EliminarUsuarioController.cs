using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Services;

namespace MiniDirve.Controllers
{
    [ApiController]
    
    public class EliminarUsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuario;

        public EliminarUsuarioController(IUsuarioRepository usuario)
        {
            _usuario = usuario;
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult EliminarUsuario(int id)
        {
            _usuario.EliminarUsuario(id);
            return Ok();
        }

        

    }
}