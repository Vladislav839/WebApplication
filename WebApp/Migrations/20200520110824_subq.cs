using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class subq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "subscribersQuantity",
                table: "UserModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "subscriptionsQuantity",
                table: "UserModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LikesPosts",
                columns: table => new
                {
                    RatingPersonId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikesPosts", x => new { x.RatingPersonId, x.PostId });
                    table.ForeignKey(
                        name: "FK_LikesPosts_PostModels_RatingPersonId",
                        column: x => x.RatingPersonId,
                        principalTable: "PostModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikesPosts_UserModels_RatingPersonId",
                        column: x => x.RatingPersonId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikesPosts");

            migrationBuilder.DropColumn(
                name: "subscribersQuantity",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "subscriptionsQuantity",
                table: "UserModels");
        }
    }
}
