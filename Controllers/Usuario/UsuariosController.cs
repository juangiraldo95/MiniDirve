using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Models;
using MiniDriveApi.Services;

namespace MiniDriveApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
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