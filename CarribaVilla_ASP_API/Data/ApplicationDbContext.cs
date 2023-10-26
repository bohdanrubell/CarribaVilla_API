using CarribaVilla_ASP_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CarribaVilla_ASP_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Villa> Villas { get; set; }

    }
}
