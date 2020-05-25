using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApp.Migrations
{
    public partial class photochki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_PostModels_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.CreateTable(
                name: "PhotoModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OwnerId = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoModels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikesPosts_PostId",
                table: "LikesPosts",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikesPosts_PostModels_PostId",
                table: "LikesPosts",
                column: "PostId",
                principalTable: "PostModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_PostModels_PostId",
                table: "LikesPosts");

            migrationBuilder.DropTable(
                name: "PhotoModels");

            migrationBuilder.DropIndex(
                name: "IX_LikesPosts_PostId",
                table: "LikesPosts");

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
