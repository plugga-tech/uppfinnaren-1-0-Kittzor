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
                    new Alster { Id = 1, Sort = "Stout", Name = "Finn", Description = "Maltig, rostad smak med liten sötma, inslag av choklad, kavring, kaffe, rostade nötter och mörk sirap.", ImageUrl = "/assets/finn.webp"},
                    new Alster { Id = 2, Sort = "Stout", Name = "Naughty & Nice", Description = "Nyanserad, maltig smak med sötma, inslag av chokladkaka, kaffe, torkad frukt, nötter och lakritsfudge.", ImageUrl = "/assets/naughty.webp"},
                    new Alster { Id = 3, Sort = "Stout", Name = "I Can’t Believe It’s NOTella", Description = "Maltig, rostad smak med sötma, inslag av chokladkaka, hasselnötter, marsipan, torkad frukt, smörkola och kaffe.", ImageUrl = "/assets/affric.webp" },
                    new Alster { Id = 4, Sort = "Stout", Name = "Månljus", Description = "Maltig smak med sötma, inslag av kavring, russin, choklad och apelsin.", ImageUrl = "/assets/månljus.webp" },
                    new Alster { Id = 5, Sort = "Lager", Name = "Ey'Bro", Description = "Maltig smak med inslag av ljust knäckebröd, citron, örter, honung och halm.", ImageUrl = "/assets/eybro.png" },
                    new Alster { Id = 6, Sort = "Lager", Name = "Mariestads Export", Description = "Maltig smak med inslag av ljust bröd, sirap och citrus.", ImageUrl = "/assets/mariestad.png"},
                    new Alster { Id = 7, Sort = "Lager", Name = "The Bear", Description = "Maltig smak med inslag av ljust bröd, örter och citrus.", ImageUrl = "/assets/bear.png" },
                    new Alster { Id = 8, Sort = "Lager", Name = "Norrlands Guld", Description = "Maltig smak med inslag av citrus, knäckebröd och örter.", ImageUrl = "/assets/norrlands.png" },
                    new Alster { Id = 9, Sort = "Ipa", Name = "100W IPA", Description = "Fruktig, humlearomatisk smak med liten sötma och tydlig beska, inslag av citronskal, ananas, passionsfrukt och mango.", ImageUrl = "/assets/100w.png" },
                    new Alster { Id = 10, Sort = "Ipa", Name = "East IPA", Description = "Nyanserad, humlearomatisk smak med tydlig beska, inslag av torkad ananas, ambrosiakaka, passionsfrukt, tallkåda och bergamott.", ImageUrl = "/assets/east.png" },
                    new Alster { Id = 11, Sort = "Ipa", Name = "A Ship Full of IPA", Description = "Nyanserad, något humlearomatisk smak med tydlig beska, med inslag av aprikosmarmelad, sirapslimpa, apelsinskal och honung.", ImageUrl = "/assets/ship.png" },
                    new Alster { Id = 12, Sort = "Ipa", Name = "Brewdog Punk IPA", Description = "Fruktig, humlearomatisk smak med tydlig beska, inslag av passionsfrukt, apelsinmarmelad, sockerkaka, rosmarin och grapefrukt.", ImageUrl = "/assets/punk.png" },
                    new Alster { Id = 13, Sort = "Julöl", Name = "Kåtöl Julöl", Description = "Maltig smak med inslag av mörkt knäckebröd, torkad frukt, kakao, kryddor och apelsin.", ImageUrl = "/assets/kåtöl.webp" },
                    new Alster { Id = 14, Sort = "Julöl", Name = "Falcons Julmumma", Description = "Kryddig, söt smak med inslag av kardemumma, vörtbröd, ljus sirap, kanel, ingefära, pomerans och choklad.", ImageUrl = "/assets/mumma.webp" },
                    new Alster { Id = 15, Sort = "Julöl", Name = "Saffron", Description = "Maltig, kryddig smak med sötma, inslag av kaffe, saffran, chokladpraliner, vaniljkola och sötlakrits.", ImageUrl = "/assets/saffron.webp" },
                    new Alster { Id = 16, Sort = "Julöl", Name = "RNB Julöl", Description = "Maltig smak med inslag av rågbröd, pomerans, dadlar, kryddor, aprikosmarmelad och knäck.", ImageUrl = "/assets/rnb.webp" }
                    

            );
        }
    }
}
