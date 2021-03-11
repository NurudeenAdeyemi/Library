using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LasttName",
                table: "Authors",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Authors",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Authors",
                maxLength: 72,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "LasttName",
                table: "Authors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 160);
        }
    }
}
