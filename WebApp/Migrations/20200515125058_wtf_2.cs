using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class wtf_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_PostModels_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropTable(
                name: "UsersPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostModels",
                table: "PostModels");

            migrationBuilder.RenameTable(
                name: "PostModels",
                newName: "PostModel");

            migrationBuilder.AddColumn<List<int>>(
                name: "Posts",
                table: "UserModels",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostModel",
                table: "PostModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_PostModel_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "PostModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_PostModel_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostModel",
                table: "PostModel");

            migrationBuilder.DropColumn(
                name: "Posts",
                table: "UserModels");

            migrationBuilder.RenameTable(
                name: "PostModel",
                newName: "PostModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostModels",
                table: "PostModels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UsersPosts",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPosts", x => new { x.OwnerId, x.PostId });
                    table.ForeignKey(
                        name: "FK_UsersPosts_UserModels_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersPosts_PostModels_PostId",
                        column: x => x.PostId,
                        principalTable: "PostModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersPosts_PostId",
                table: "UsersPosts",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_PostModels_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "PostModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
