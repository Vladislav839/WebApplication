using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class UserToModel___ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_User_Person1Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_User_Person2Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_UserModelId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_UserModelId1",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_User_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_Users_UserModelId",
                table: "LikesPosts");

            migrationBuilder.DropIndex(
                name: "IX_LikesPosts_UserModelId",
                table: "LikesPosts");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserModelId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserModelId1",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "LikesPosts");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserModelId1",
                table: "Friends");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LikesPosts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Friends",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LikesPosts_UserId",
                table: "LikesPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserId",
                table: "Friends",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserId1",
                table: "Friends",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_Person1Id",
                table: "Friends",
                column: "Person1Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_Person2Id",
                table: "Friends",
                column: "Person2Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_User_UserId",
                table: "Friends",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_User_UserId1",
                table: "Friends",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_Users_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_User_UserId",
                table: "LikesPosts",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_Person1Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_Person2Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_User_UserId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_User_UserId1",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_Users_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_User_UserId",
                table: "LikesPosts");

            migrationBuilder.DropIndex(
                name: "IX_LikesPosts_UserId",
                table: "LikesPosts");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserId1",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LikesPosts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Friends");

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "LikesPosts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Friends",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserModelId1",
                table: "Friends",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LikesPosts_UserModelId",
                table: "LikesPosts",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserModelId",
                table: "Friends",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserModelId1",
                table: "Friends",
                column: "UserModelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_User_Person1Id",
                table: "Friends",
                column: "Person1Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_User_Person2Id",
                table: "Friends",
                column: "Person2Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_UserModelId",
                table: "Friends",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_UserModelId1",
                table: "Friends",
                column: "UserModelId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_User_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_Users_UserModelId",
                table: "LikesPosts",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
