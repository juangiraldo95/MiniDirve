using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniDriveApi.Controllers;
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
            MailController Email = new MailController();

                try
                {
                    _usuario.AgregarUsuario(usuario); // 

                    // Envía el correo de bienvenida al nuevo usuario
                    Email.EnviarCorreo(usuario);

                    return Ok("Usuario creado correctamente y correo de bienvenida enviado.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear usuario o enviar correo de bienvenida: {ex.Message}");
                    return StatusCode(500, "Error interno al procesar la solicitud.");
                }
            }
        
    }
}