

using Microsoft.EntityFrameworkCore;
using MiniDriveApi.Dtos;
using MiniDriveApi.Models;

namespace MiniDriveApi.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options){

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carpeta> Carpetas { get; set; }
        public DbSet<Archivo> Archivos { get; set; }
    }
}