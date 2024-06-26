using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public interface IArchivoRepository
    {
        IEnumerable<Archivo> ObtenerArchivos();
        Archivo ObtenerArchivoId(int id);
        void AgragarArchivo(Archivo archivo);
        void ActualizarArchivo(Archivo archivo);
        void EliminarArchivo(int id);
        
    }
}