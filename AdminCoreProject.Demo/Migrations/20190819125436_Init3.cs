using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminCoreProject.Demo.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRegistration_Users_Userid",
                table: "UserRegistration");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "UserRegistration",
                newName: "UserRegistirationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRegistration_Userid",
                table: "UserRegistration",
                newName: "IX_UserRegistration_UserRegistirationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRegistration_Users_UserRegistirationTypeId",
                table: "UserRegistration",
                column: "UserRegistirationTypeId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRegistration_Users_UserRegistirationTypeId",
                table: "UserRegistration");

            migrationBuilder.RenameColumn(
                name: "UserRegistirationTypeId",
                table: "UserRegistration",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_UserRegistration_UserRegistirationTypeId",
                table: "UserRegistration",
                newName: "IX_UserRegistration_Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRegistration_Users_Userid",
                table: "UserRegistration",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
