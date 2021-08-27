using dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Character> Characters {get; set;}    // Create Chatacters table.
        public DbSet<User> Users {get; set;}  // Create users table.
        public DbSet<Weapon> Weapons {get; set;} // Create users weapons.
        public DbSet<Skill> Skills {get; set;}
    }
}