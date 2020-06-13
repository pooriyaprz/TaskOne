using Microsoft.EntityFrameworkCore.Migrations;

namespace Task1.Migrations
{
    public partial class changeProperty2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Properties",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Number",
                table: "Properties",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
