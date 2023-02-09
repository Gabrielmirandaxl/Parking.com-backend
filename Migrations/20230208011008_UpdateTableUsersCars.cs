using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace estudoscrud.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableUsersCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tb_usersCars");

            migrationBuilder.RenameColumn(
                name: "RegisterCar",
                table: "tb_usersCars",
                newName: "registerCar");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "tb_usersCars",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_usersCars",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "tb_usersCars",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_usersCars",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Plate",
                table: "tb_usersCars",
                newName: "palte");

            migrationBuilder.UpdateData(
                table: "tb_usersCars",
                keyColumn: "phone",
                keyValue: null,
                column: "phone",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "tb_usersCars",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_usersCars",
                keyColumn: "name",
                keyValue: null,
                column: "name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tb_usersCars",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_usersCars",
                keyColumn: "color",
                keyValue: null,
                column: "color",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "color",
                table: "tb_usersCars",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tb_usersCars",
                keyColumn: "palte",
                keyValue: null,
                column: "palte",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "palte",
                table: "tb_usersCars",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_usersCars",
                table: "tb_usersCars",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_usersCars",
                table: "tb_usersCars");

            migrationBuilder.RenameTable(
                name: "tb_usersCars",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "registerCar",
                table: "Users",
                newName: "RegisterCar");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Users",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "palte",
                table: "Users",
                newName: "Plate");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
