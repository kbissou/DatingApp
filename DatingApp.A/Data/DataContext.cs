

using DatingApp.A.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.A.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){ }

        public DbSet<Value> Values { get; set; }
    
    }
}