using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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

        public void AgregarUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public Usuario ObtenerUsuarioId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            _context.Update(usuario);
            _context.SaveChanges();
        }


    }
}