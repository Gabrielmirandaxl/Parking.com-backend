using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estudoscrud.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFielCpf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "tb_usersCars",
                newName: "cpf");

            migrationBuilder.UpdateData(
                table: "tb_usersCars",
                keyColumn: "cpf",
                keyValue: null,
                column: "cpf",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "tb_usersCars",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "tb_usersCars",
                newName: "Cpf");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "tb_usersCars",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
