using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminCoreProject.Demo.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRegistration_Users_UserRegistirationTypeId",
                table: "UserRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration");

            migrationBuilder.RenameTable(
                name: "UserRegistration",
                newName: "UserRegistrations");

            migrationBuilder.RenameIndex(
                name: "IX_UserRegistration_UserRegistirationTypeId",
                table: "UserRegistrations",
                newName: "IX_UserRegistrations_UserRegistirationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRegistrations",
                table: "UserRegistrations",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRegistrations_Users_UserRegistirationTypeId",
                table: "UserRegistrations",
                column: "UserRegistirationTypeId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRegistrations_Users_UserRegistirationTypeId",
                table: "UserRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRegistrations",
                table: "UserRegistrations");

            migrationBuilder.RenameTable(
                name: "UserRegistrations",
                newName: "UserRegistration");

            migrationBuilder.RenameIndex(
                name: "IX_UserRegistrations_UserRegistirationTypeId",
                table: "UserRegistration",
                newName: "IX_UserRegistration_UserRegistirationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRegistration_Users_UserRegistirationTypeId",
                table: "UserRegistration",
                column: "UserRegistirationTypeId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
