using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApp.Migrations
{
    public partial class postpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "PostModel",
                newName: "owner");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LikesPosts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NickName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostModel_OwnerId",
                table: "PostModel",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_LikesPosts_UserId",
                table: "LikesPosts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_User_UserId",
                table: "LikesPosts",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostModel_User_OwnerId",
                table: "PostModel",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_User_UserId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_PostModel_User_OwnerId",
                table: "PostModel");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_PostModel_OwnerId",
                table: "PostModel");

            migrationBuilder.DropIndex(
                name: "IX_LikesPosts_UserId",
                table: "LikesPosts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LikesPosts");

            migrationBuilder.RenameColumn(
                name: "owner",
                table: "PostModel",
                newName: "Owner");
        }
    }
}
