using Microsoft.EntityFrameworkCore.Migrations;

namespace ThayNailDesign.Migrations
{
    public partial class private_chate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TargetId",
                table: "Message",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TargetName",
                table: "Message",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TargetUserId",
                table: "Message",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_TargetUserId",
                table: "Message",
                column: "TargetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_TargetUserId",
                table: "Message",
                column: "TargetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_TargetUserId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_TargetUserId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "TargetName",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "TargetUserId",
                table: "Message");
        }
    }
}
