using System.Data.Entity;

namespace yaziliweb.Models.siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<flex> flexs { get; set; }
    }
}