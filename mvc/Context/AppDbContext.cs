using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<TipoOcorrencia> TipoOcorrencia { get; set; }
    public DbSet<Denuncia> Denuncia { get; set; }
    
}