using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class remove_evr_exc_users_posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostModel_User_OwnerId",
                table: "PostModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PostModel_UserModels_UserModelId",
                table: "PostModel");

            migrationBuilder.DropTable(
                name: "LikesPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostModel",
                table: "PostModel");

            migrationBuilder.RenameTable(
                name: "PostModel",
                newName: "PostModels");

            migrationBuilder.RenameIndex(
                name: "IX_PostModel_UserModelId",
                table: "PostModels",
                newName: "IX_PostModels_UserModelId");

            migrationBuilder.RenameIndex(
                name: "IX_PostModel_OwnerId",
                table: "PostModels",
                newName: "IX_PostModels_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostModels",
                table: "PostModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostModels_User_OwnerId",
                table: "PostModels",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostModels_UserModels_UserModelId",
                table: "PostModels",
                column: "UserModelId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostModels_User_OwnerId",
                table: "PostModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PostModels_UserModels_UserModelId",
                table: "PostModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostModels",
                table: "PostModels");

            migrationBuilder.RenameTable(
                name: "PostModels",
                newName: "PostModel");

            migrationBuilder.RenameIndex(
                name: "IX_PostModels_UserModelId",
                table: "PostModel",
                newName: "IX_PostModel_UserModelId");

            migrationBuilder.RenameIndex(
                name: "IX_PostModels_OwnerId",
                table: "PostModel",
                newName: "IX_PostModel_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostModel",
                table: "PostModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LikesPosts",
                columns: table => new
                {
                    RatingPersonId = table.Column<int>(type: "integer", nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikesPosts", x => new { x.RatingPersonId, x.PostId });
                    table.ForeignKey(
                        name: "FK_LikesPosts_PostModel_RatingPersonId",
                        column: x => x.RatingPersonId,
                        principalTable: "PostModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikesPosts_UserModels_RatingPersonId",
                        column: x => x.RatingPersonId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikesPosts_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikesPosts_UserId",
                table: "LikesPosts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostModel_User_OwnerId",
                table: "PostModel",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostModel_UserModels_UserModelId",
                table: "PostModel",
                column: "UserModelId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
