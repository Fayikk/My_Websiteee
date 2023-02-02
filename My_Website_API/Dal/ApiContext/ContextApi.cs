using Microsoft.EntityFrameworkCore;
using My_Website_API.Dal.Entity;

namespace My_Website_API.Dal.ApiContext
{
    public class ContextApi : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=FAYIK;database=DenemeDm; integrated security=true");
        }


        public DbSet<Category> Categories { get; set; }
    }
}
