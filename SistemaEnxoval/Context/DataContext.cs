using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SistemaEnxoval.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public DbSet<UserRepository> Users { get; set; }
        public DbSet<ItemRepository> Items { get; set; }
        public DbSet<UserItemRepository> UserItems { get; set; }
    }
}
