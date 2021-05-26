using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RustaConsumerList.Models;

namespace RustaConsumerList
{

    /*Install-Package Microsoft.Extensions.Configuration
    Install-Package Microsoft.Extensions.Configuration.FileExtensions
    Install-Package Microsoft.Extensions.Configuration.Json
    Install-Package Microsoft.EntityFrameworkCore.SqlServer
    Install-Package Microsoft.EntityFrameworkCore.Tools
     
     */

    public class EFContext : DbContext, IEFContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ConsumptionProduct>();
            modelBuilder.Entity<ProductImage>();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ConsumptionProduct> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        //Skjut ut databas genom Add-Migration i Package Manager Console. Ex. Add-Migration "V2"
    }
}