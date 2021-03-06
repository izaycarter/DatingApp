using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
// updating model or data? migrate next
namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
    }
}