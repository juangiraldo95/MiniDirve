using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniDriveApi.Data;
using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public class CarpetaRepository : ICarpetaRepository
    {

        private readonly BaseContext _context;
        public CarpetaRepository(BaseContext context){
            _context = context;
        }
        public void ActualizarCarpeta(Carpeta carpeta)
        {
            _context.Update(carpeta);
            _context.SaveChanges();
        }

        public void AgregarCarpeta(Carpeta carpeta)
        {
            _context.Add(carpeta);
            _context.SaveChanges();
        }

        public void EliminarCarpeta(int id)
        {
             _context.Remove(id);
            _context.SaveChanges();
        }

        public Carpeta ObtenerCarpetaId(int id)
        {
             return _context.Carpetas.Find(id);
        }

        public IEnumerable<Carpeta> ObtenerCarpetas()
        {
            return _context.Carpetas.ToList();
        }
    }
}