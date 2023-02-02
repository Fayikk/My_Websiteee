using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_Website_API.Dal.Entity;

namespace My_Website_API.Dal.ApiContext
{
    public class ContextApi : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=FAYIK;database=DenemeDm; integrated security=true");
        }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
