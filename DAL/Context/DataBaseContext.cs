using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ContactDb;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;Persist Security Info=True;User ID=sa;Password=123456");
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
