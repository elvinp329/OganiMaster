using Microsoft.EntityFrameworkCore;
using OganiMaster.MVC.DAL.Entities;

namespace OganiMaster.MVC.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
