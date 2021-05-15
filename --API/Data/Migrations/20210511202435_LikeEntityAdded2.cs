using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class LikeEntityAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_LikeUserId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "LikeUserId",
                table: "Likes",
                newName: "LikedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_LikeUserId",
                table: "Likes",
                newName: "IX_Likes_LikedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_LikedUserId",
                table: "Likes",
                column: "LikedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_LikedUserId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "LikedUserId",
                table: "Likes",
                newName: "LikeUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_LikedUserId",
                table: "Likes",
                newName: "IX_Likes_LikeUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_LikeUserId",
                table: "Likes",
                column: "LikeUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
