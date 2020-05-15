using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApp.Migrations
{
    public partial class wtf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_PersonInputRequestId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_PersonOutputRequestId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_User_UserId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_User_UserId1",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_Posts_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_Users_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_User_UserId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_User_UserId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_User_UserId1",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Users_senderId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Users_targetId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_User_OwnerId",
                table: "UsersPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_Posts_PostId",
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
                name: "IX_Subscribers_UserId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_UserId1",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_LikesPosts_UserId",
                table: "LikesPosts");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserId1",
                table: "Friends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "UsersPosts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LikesPosts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Friends");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UserModels");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "PostModels");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PostModels",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserModels",
                table: "UserModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostModels",
                table: "PostModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_UserModels_PersonInputRequestId",
                table: "Friends",
                column: "PersonInputRequestId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_UserModels_PersonOutputRequestId",
                table: "Friends",
                column: "PersonOutputRequestId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_PostModels_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "PostModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_UserModels_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_UserModels_senderId",
                table: "Subscribers",
                column: "senderId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_UserModels_targetId",
                table: "Subscribers",
                column: "targetId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_UserModels_OwnerId",
                table: "UsersPosts",
                column: "OwnerId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_PostModels_PostId",
                table: "UsersPosts",
                column: "PostId",
                principalTable: "PostModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_UserModels_PersonInputRequestId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_UserModels_PersonOutputRequestId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_PostModels_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_UserModels_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_UserModels_senderId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_UserModels_targetId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_UserModels_OwnerId",
                table: "UsersPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_PostModels_PostId",
                table: "UsersPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserModels",
                table: "UserModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostModels",
                table: "PostModels");

            migrationBuilder.RenameTable(
                name: "UserModels",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "PostModels",
                newName: "Posts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "UsersPosts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Subscribers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Subscribers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LikesPosts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Friends",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Friends",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NickName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true)
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
                name: "IX_Subscribers_UserId",
                table: "Subscribers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_UserId1",
                table: "Subscribers",
                column: "UserId1");

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
                name: "FK_Friends_Users_PersonInputRequestId",
                table: "Friends",
                column: "PersonInputRequestId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_PersonOutputRequestId",
                table: "Friends",
                column: "PersonOutputRequestId",
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
                name: "FK_LikesPosts_Posts_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_User_UserId",
                table: "Subscribers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_User_UserId1",
                table: "Subscribers",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Users_senderId",
                table: "Subscribers",
                column: "senderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Users_targetId",
                table: "Subscribers",
                column: "targetId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_User_OwnerId",
                table: "UsersPosts",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_Posts_PostId",
                table: "UsersPosts",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_Users_UserModelId",
                table: "UsersPosts",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
