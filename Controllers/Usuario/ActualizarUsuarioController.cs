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
    public class ActualizarUsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _Usuario;

        public ActualizarUsuarioController(IUsuarioRepository usuario)
        {
            _Usuario = usuario;
        }

        [HttpPut]
        [Route("api/[controller]/{Id}")]
        public IActionResult ActualizarUsuario(int Id, [FromBody] Usuario usuario)
        {

            var usuarioExistente = _Usuario.ObtenerUsuarioId(Id);
            if (usuario == null)
            {
                return NotFound();
            }
            usuario.Id = usuarioExistente.Id;
            usuario.Nombres = usuarioExistente.Nombres;
            usuario.Apellidos = usuarioExistente.Apellidos;
            usuario.Correo = usuarioExistente.Correo;
            usuario.Contrasena = usuarioExistente.Contrasena;

            _Usuario.ActualizarUsuario(usuarioExistente);
            return Ok("Usuario actualizado correctamente");
        }
        

        
    }
}