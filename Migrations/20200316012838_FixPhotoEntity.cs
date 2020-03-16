using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_API.Migrations
{
    public partial class FixPhotoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Products_ProductId1",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ProductId1",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Photos");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Photos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Products_ProductId",
                table: "Photos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Products_ProductId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ProductId",
                table: "Photos");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Photos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId1",
                table: "Photos",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Products_ProductId1",
                table: "Photos",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
