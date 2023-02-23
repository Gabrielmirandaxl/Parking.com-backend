using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estudoscrud.Migrations
{
    /// <inheritdoc />
    public partial class FieldPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Payment",
                table: "tb_usersCars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment",
                table: "tb_usersCars");
        }
    }
}
