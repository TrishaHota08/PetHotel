using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHotelData.Migrations
{
    public partial class addPhotocolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Cats",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Cats");
        }
    }
}
