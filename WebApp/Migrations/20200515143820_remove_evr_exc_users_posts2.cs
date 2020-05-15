using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApp.Migrations
{
    public partial class remove_evr_exc_users_posts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostModels_User_OwnerId",
                table: "PostModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PostModels_UserModels_UserModelId",
                table: "PostModels");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_PostModels_UserModelId",
                table: "PostModels");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "PostModels");

            migrationBuilder.AddForeignKey(
                name: "FK_PostModels_UserModels_OwnerId",
                table: "PostModels",
                column: "OwnerId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostModels_UserModels_OwnerId",
                table: "PostModels");

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "PostModels",
                type: "integer",
                nullable: true);

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
                name: "IX_PostModels_UserModelId",
                table: "PostModels",
                column: "UserModelId");

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
    }
}
