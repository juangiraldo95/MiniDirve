using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Models;
using MiniDriveApi.Services;

namespace MiniDriveApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuario;

        public UsuariosController(IUsuarioRepository usuario)
        {
            _usuario = usuario;
        }
        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios(){
            return _usuario.GetUsuarios();
        }
    }
}