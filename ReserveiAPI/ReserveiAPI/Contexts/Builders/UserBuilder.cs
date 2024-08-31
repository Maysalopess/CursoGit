

using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Contexts.Builders
{
    public class UserBuilder
    {

        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasKey(user => user.Id);
            modelBuilder.Entity<UserModel>().Property(user => user.ImageProfile);
            modelBuilder.Entity<UserModel>().Property(user => user.NameUser).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<UserModel>().Property(user => user.EmailUser).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<UserModel>().Property(user => user.PasswordUser).HasMaxLength(256).IsRequired();
            modelBuilder.Entity<UserModel>().Property(user => user.PhoneUser).HasMaxLength(15).IsRequired();

            modelBuilder.Entity<UserModel>().HasData(
            new UserModel
            {
                Id = 1,
                NameUser = "Master",
                EmailUser = "master@dev.com",
                PasswordUser = "15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225",
                PhoneUser = "",
                ImageProfile = ""
            }
            );
        }

    }
}
