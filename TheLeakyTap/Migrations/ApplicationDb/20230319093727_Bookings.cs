using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheLeakyTap.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class Bookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bookingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    bookingName = table.Column<string>(type: "TEXT", nullable: false),
                    bookingType = table.Column<string>(type: "TEXT", nullable: false),
                    bookingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    bookingGuests = table.Column<int>(type: "INTEGER", nullable: false),
                    bookingNotes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.bookingID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
