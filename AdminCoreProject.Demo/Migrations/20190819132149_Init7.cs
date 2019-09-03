using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminCoreProject.Demo.Migrations
{
    public partial class Init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRegistrations_Users_UserRegistirationTypeId",
                table: "UserRegistrations");

            migrationBuilder.RenameColumn(
                name: "UserRegistirationTypeId",
                table: "UserRegistrations",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_UserRegistrations_UserRegistirationTypeId",
                table: "UserRegistrations",
                newName: "IX_UserRegistrations_Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRegistrations_Users_Userid",
                table: "UserRegistrations",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRegistrations_Users_Userid",
                table: "UserRegistrations");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "UserRegistrations",
                newName: "UserRegistirationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRegistrations_Userid",
                table: "UserRegistrations",
                newName: "IX_UserRegistrations_UserRegistirationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRegistrations_Users_UserRegistirationTypeId",
                table: "UserRegistrations",
                column: "UserRegistirationTypeId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
