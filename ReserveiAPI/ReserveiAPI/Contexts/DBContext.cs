using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Contexts.Builders;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Contexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<UserModel> User { get; set;}

        protected override void OnModelCreating (ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            UserBuilder.Build(modelBuilder);
        }


    }
}
