using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {

        }
        public ModelContext(DbContextOptions opt) : base(opt)
        {

        } 
        public DbSet<Todotask> todotasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;userid=root;password=123123;database=tododb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
