using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_efcorePeople.Migrations
{
    public partial class removePhoneAtribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "People",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "address",
                table: "People",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "People",
                nullable: true);
        }
    }
}
