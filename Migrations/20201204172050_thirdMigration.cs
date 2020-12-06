using Microsoft.EntityFrameworkCore.Migrations;

namespace PartyInvitation.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "WillAttend",
                table: "MyInvitees",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "WillAttend",
                table: "MyInvitees",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
