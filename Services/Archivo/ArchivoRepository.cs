using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniDriveApi.Data;
using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public class ArchivoRepository : IArchivoRepository
    {

        private readonly BaseContext _context;
        public ArchivoRepository(BaseContext context){
            _context = context;
        }
        
        public void ActualizarArchivo(Archivo archivo)
        {
             _context.Update(archivo);
            _context.SaveChanges();
        }

        public void AgragarArchivo(Archivo archivo)
        {
            _context.Add(archivo);
            _context.SaveChanges();
        }

        public void EliminarArchivo(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public Archivo ObtenerArchivoId(int id)
        {
            return _context.Archivos.Find(id);
        }

        public IEnumerable<Archivo> ObtenerArchivos()
        {
            return _context.Archivos.Include(u => u.Carpeta).ToList();
        }
    }
}