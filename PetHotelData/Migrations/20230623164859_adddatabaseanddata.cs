using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHotelData.Migrations
{
    public partial class adddatabaseanddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CageLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ownerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ownerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ownerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatsId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatsId", "ArrivalDate", "CageLocation", "CatName", "Description", "EstimatedDepartureDate", "ownerEmail", "ownerName", "ownerPhone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1A", "Lucy", "black cat", new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah123@gmail.com", "Sarah", "8956789" },
                    { 2, new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "1D", "Winny", "fluffy cat", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "william567@gmail.com", "Wiiliam", "67658978" },
                    { 3, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2A", "Edee", "white cat with brown patches", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "alwex@gmail.com", "Alex", "7677868" },
                    { 4, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2C", "Tuffy", "thin cat", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alwex@gmail.com", "Alex", "7677868" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}
