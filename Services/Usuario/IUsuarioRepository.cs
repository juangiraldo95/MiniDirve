using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetUsuarios();
        Usuario GetUsuario(int id);
        Usuario AddUsuario(Usuario carpeta);
        Usuario UpdateUsuario(Usuario carpeta);
        Usuario DeleteUsuario(int id);
    }
}