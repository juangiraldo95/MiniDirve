using MiniDriveApi.Data;
using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly BaseContext _context;
        public UsuarioRepository(BaseContext context){
            _context = context;
        }

        public Usuario AddUsuario(Usuario carpeta)
        {
            throw new NotImplementedException();
        }

        public Usuario DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario UpdateUsuario(Usuario carpeta)
        {
            throw new NotImplementedException();
        }
    }
}