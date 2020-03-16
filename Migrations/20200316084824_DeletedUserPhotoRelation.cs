using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_API.Migrations
{
    public partial class DeletedUserPhotoRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UserId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Photos");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Photos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
