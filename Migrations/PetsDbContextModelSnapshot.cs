﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using l10_assignment.Migrations;

#nullable disable

namespace l10_assignment.Migrations
{
    [DbContext(typeof(PetsDbContext))]
    partial class PetsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("l10_assignment.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PetId");

                    b.ToTable("Pet");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            Description = "Who does not love a cat with the PURRFECT Mustache? He will be the most popular guy at the party! Charlie will need more than one litter box around the house and he prefers his boxes BIG!",
                            PetName = "Charlie",
                            Type = "Cat"
                        },
                        new
                        {
                            PetId = 2,
                            Description = "Sarge is very playful and generally well-mannered. He will play fetch (and he actually brings the ball back- most of the time!). He learns routines very well, and will know when it's time for dinner, play, or to go outside. He loves back and belly rubs, and will happily present himself for scratches at just about any time. While he is a senior, you wouldn't know it from the way he plays!",
                            PetName = "Sarge",
                            Type = "Dog"
                        },
                        new
                        {
                            PetId = 3,
                            Description = "He is a petite dog, just the perfect size. He absolutely adores being outside. He loves to run and spin. He comes to the window when he is ready to come back inside. He is very sweet and quiet, does not make a lot of noise, and loves his chew toys so that is a must! He is an overall sweetheart once he knows he is safe and feels comfortable.",
                            PetName = "Bullwinkle",
                            Type = "Dog"
                        },
                        new
                        {
                            PetId = 4,
                            Description = "If you can find a space in your home near the sunshine through your window, Coco would love to be a part of your family. This gorgeous calico can not wait to have a family of her own once again. She is roughly 4 years old and has many many years of love to share.",
                            PetName = "Coco",
                            Type = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
