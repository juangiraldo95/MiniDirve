using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public interface IArchivoRepository
    {
        IEnumerable<Archivo> GetArchivos();
        Archivo GetArchivo(int id);
        Archivo AddArchivo(Archivo archivo);
        Archivo UpdateArchivo(Archivo archivo);
        Archivo DeleteArchivo(int id);
        
    }
}