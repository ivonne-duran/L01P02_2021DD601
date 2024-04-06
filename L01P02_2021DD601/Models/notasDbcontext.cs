using Microsoft.EntityFrameworkCore;
namespace L01P02_2021DD601.Models
{
    public class notasDbcontext : DbContext
    {
        public notasDbcontext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
    }
}