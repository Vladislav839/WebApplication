using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApp.Migrations
{
    public partial class UserToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_Person1Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_Person2Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_Users_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_Users_OwnerId",
                table: "UsersPosts");

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "UsersPosts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "LikesPosts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserModelId1",
                table: "Friends",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NickName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersPosts_UserModelId",
                table: "UsersPosts",
                column: "UserModelId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_User_OwnerId",
                table: "UsersPosts",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_Users_UserModelId",
                table: "UsersPosts",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_User_OwnerId",
                table: "UsersPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_Users_UserModelId",
                table: "UsersPosts");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_UsersPosts_UserModelId",
                table: "UsersPosts");

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
                table: "UsersPosts");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "LikesPosts");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserModelId1",
                table: "Friends");

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
                name: "FK_LikesPosts_Users_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_Users_OwnerId",
                table: "UsersPosts",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
