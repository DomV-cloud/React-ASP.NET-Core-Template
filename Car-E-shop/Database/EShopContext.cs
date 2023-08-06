using Microsoft.EntityFrameworkCore;

namespace Car_E_shop.Database
{
    public class EShopContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Eshop;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
