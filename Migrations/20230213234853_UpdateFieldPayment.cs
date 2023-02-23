using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estudoscrud.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFieldPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Payment",
                table: "tb_usersCars",
                newName: "payment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "payment",
                table: "tb_usersCars",
                newName: "Payment");
        }
    }
}
