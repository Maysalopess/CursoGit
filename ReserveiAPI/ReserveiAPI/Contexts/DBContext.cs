using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Contexts.Builders;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Contexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set;}

        protected override void OnModelCreating (ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            UserBuilder.Build(modelBuilder);
        }


    }
}
