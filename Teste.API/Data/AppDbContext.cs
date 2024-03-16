using Teste.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Teste.API.Data
{
        public class AppDbContext : DbContext{
            
            public DbSet<Product>? Products {get; set;}
      


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource=tds.db;cache=Shared");
        }
    }
}