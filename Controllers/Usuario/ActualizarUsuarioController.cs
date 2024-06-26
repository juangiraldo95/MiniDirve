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
        [Route("api/[controller]/{id}")]
        public IActionResult ActualizarUsuario(int id, [FromBody] Usuario usuario)
        {

            var usuarioExistente = _Usuario.ObtenerUsuarioId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            usuarioExistente.Id = usuario.Id;
            usuarioExistente.Nombres = usuario.Nombres;
            usuarioExistente.Apellidos = usuario.Apellidos;
            usuarioExistente.Correo = usuario.Correo;
            usuarioExistente.Contrasena = usuario.Contrasena;

            _Usuario.ActualizarUsuario(usuarioExistente);
            return Ok("Usuario actualizado correctamente");
        }
        

        
    }
}