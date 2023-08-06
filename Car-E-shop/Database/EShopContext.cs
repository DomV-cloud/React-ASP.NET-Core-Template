using Car_E_shop.LoggingMessages;
using Car_E_shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Car_E_shop.Database
{
    public class EShopContext: DbContext
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<EShopContext> _logger;

        public DbSet<Car> Cars { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public EShopContext(IConfiguration configuration, ILogger<EShopContext> logger )
        {
            _configuration = configuration;
            _logger = logger;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("connection")!;

            if (connectionString is null || String.IsNullOrEmpty(connectionString) )
            {
                _logger.LogError(LogMessage.SQLIsNotConfigured);
            }

           
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Owner)
                .WithMany()
                .HasForeignKey(o => o.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Zde můžete nastavit další konfigurace pro vztahy mezi entitami, pokud je to potřeba.

            base.OnModelCreating(modelBuilder);
        }
    }
}
