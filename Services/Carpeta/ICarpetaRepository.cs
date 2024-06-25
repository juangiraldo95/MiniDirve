using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniDriveApi.Models;

namespace MiniDriveApi.Services
{
    public interface ICarpetaRepository
    {
        IEnumerable<Carpeta> GetCarpetas();
        Carpeta GetCarpeta(int id);
        Carpeta AddCarpeta(Carpeta carpeta);
        Carpeta UpdateCarpeta(Carpeta carpeta);
        Carpeta DeleteCarpeta(int id);
    }
}