using l10_assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace l10_assignment.Migrations;

public class PetsDbContext : DbContext
{
    public DbSet<Pet> Pet { get; set; }
    public PetsDbContext(DbContextOptions<PetsDbContext> options)
        : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId);
            entity.Property(e => e.PetName).IsRequired();
            entity.Property(e => e.Type).IsRequired();
            entity.Property(e => e.Description).IsRequired();
        });
        modelBuilder.Entity<Pet>().HasData(
            new Pet {
                PetId = 1,
                PetName = "Charlie",
                Type = "Cat",
                Description = "Who does not love a cat with the PURRFECT Mustache? He will be the most popular guy at the party! Charlie will need more than one litter box around the house and he prefers his boxes BIG!"
            },
            new Pet {
                PetId = 2,
                PetName = "Sarge",
                Type = "Dog",
                Description = "Sarge is very playful and generally well-mannered. He will play fetch (and he actually brings the ball back- most of the time!). He learns routines very well, and will know when it's time for dinner, play, or to go outside. He loves back and belly rubs, and will happily present himself for scratches at just about any time. While he is a senior, you wouldn't know it from the way he plays!"
            },
            new Pet {
                PetId = 3,
                PetName = "Bullwinkle",
                Type = "Dog",
                Description = "He is a petite dog, just the perfect size. He absolutely adores being outside. He loves to run and spin. He comes to the window when he is ready to come back inside. He is very sweet and quiet, does not make a lot of noise, and loves his chew toys so that is a must! He is an overall sweetheart once he knows he is safe and feels comfortable."
            },
            new Pet {
                PetId = 4,
                PetName = "Coco",
                Type = "Cat",
                Description = "If you can find a space in your home near the sunshine through your window, Coco would love to be a part of your family. This gorgeous calico can not wait to have a family of her own once again. She is roughly 4 years old and has many many years of love to share."
            }
);
    }
}