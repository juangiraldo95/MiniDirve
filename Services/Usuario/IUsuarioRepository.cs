using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> ObtenerUsuarios();
        Usuario ObtenerUsuarioId(int id);
        void AgregarUsuario(Usuario usuario);
        void ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int id);
    }
}