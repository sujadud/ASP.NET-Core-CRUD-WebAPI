using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Models
{
    public class ContactDbEintities : DbContext
    {
        public ContactDbEintities(DbContextOptions options) : base(options) { }
        public DbSet<Contacts> Contacts { get; set; }
    }
}
