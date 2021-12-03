using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class createFKinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ConsultantsID",
                table: "Meetings",
                column: "ConsultantsID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultants_UserId",
                table: "Consultants",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultants_Users_UserId",
                table: "Consultants",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Consultants_ConsultantsID",
                table: "Meetings",
                column: "ConsultantsID",
                principalTable: "Consultants",
                principalColumn: "ConsultantsID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultants_Users_UserId",
                table: "Consultants");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Consultants_ConsultantsID",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_ConsultantsID",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Consultants_UserId",
                table: "Consultants");
        }
    }
}
