using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Car_E_shop.Database
{
    public class EShopContext: DbContext
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<EShopContext> _logger;

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
                _logger.LogError("Connection to SQL server is not configured");
            }

           
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
