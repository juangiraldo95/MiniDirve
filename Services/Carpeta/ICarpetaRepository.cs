using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public interface ICarpetaRepository
    {
        IEnumerable<Carpeta> ObtenerCarpetas();
        Carpeta ObtenerCarpetaId(int id);
        void AgregarCarpeta(Carpeta carpeta);
        void ActualizarCarpeta(Carpeta carpeta);
        void EliminarCarpeta(int id);
    }
}