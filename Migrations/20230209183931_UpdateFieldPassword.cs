using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estudoscrud.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFieldPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "tb_usersCars",
                newName: "password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "tb_usersCars",
                newName: "Password");
        }
    }
}
