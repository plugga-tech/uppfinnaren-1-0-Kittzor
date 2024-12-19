using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Alster> Alsters { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alster>().HasData(
                    new Alster { Id = 1, Sort = "Stout", Name = "testStout1", Description = "Test", ImageUrl = "!"},
                    new Alster { Id = 2, Sort = "Stout", Name = "testStout2", Description = "Test", ImageUrl = "!"},
                    new Alster { Id = 3, Sort = "Stout", Name = "testStout3", Description = "Test", ImageUrl = "!" },
                    new Alster { Id = 4, Sort = "Stout", Name = "testStout4", Description = "Test", ImageUrl = "!" },
                    new Alster { Id = 5, Sort = "Lager", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 6, Sort = "Lager", Name = "lager1", Description = "test", ImageUrl = "!"},
                    new Alster { Id = 7, Sort = "Lager", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 8, Sort = "Lager", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 9, Sort = "Ipa", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 10, Sort = "Ipa", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 11, Sort = "Ipa", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 12, Sort = "Ipa", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 13, Sort = "Julöl", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 14, Sort = "Julöl", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 15, Sort = "Julöl", Name = "lager1", Description = "test", ImageUrl = "!" },
                    new Alster { Id = 16, Sort = "Julöl", Name = "lager1", Description = "test", ImageUrl = "!" }
                    

            );
        }
    }
}
