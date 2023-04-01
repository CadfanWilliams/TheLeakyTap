using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheLeakyTap.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class changedBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Bookings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "Bookings");
        }
    }
}
