using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace l10_assignment.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PetName = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetId);
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "PetId", "Description", "PetName", "Type" },
                values: new object[] { 1, "Who does not love a cat with the PURRFECT Mustache? He will be the most popular guy at the party! Charlie will need more than one litter box around the house and he prefers his boxes BIG!", "Charlie", "Cat" });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "PetId", "Description", "PetName", "Type" },
                values: new object[] { 2, "Sarge is very playful and generally well-mannered. He will play fetch (and he actually brings the ball back- most of the time!). He learns routines very well, and will know when it's time for dinner, play, or to go outside. He loves back and belly rubs, and will happily present himself for scratches at just about any time. While he is a senior, you wouldn't know it from the way he plays!", "Sarge", "Dog" });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "PetId", "Description", "PetName", "Type" },
                values: new object[] { 3, "He is a petite dog, just the perfect size. He absolutely adores being outside. He loves to run and spin. He comes to the window when he is ready to come back inside. He is very sweet and quiet, does not make a lot of noise, and loves his chew toys so that is a must! He is an overall sweetheart once he knows he is safe and feels comfortable.", "Bullwinkle", "Dog" });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "PetId", "Description", "PetName", "Type" },
                values: new object[] { 4, "If you can find a space in your home near the sunshine through your window, Coco would love to be a part of your family. This gorgeous calico can not wait to have a family of her own once again. She is roughly 4 years old and has many many years of love to share.", "Coco", "Cat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
