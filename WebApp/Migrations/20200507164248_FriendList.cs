using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApp.Migrations
{
    public partial class FriendList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Person1Id = table.Column<int>(nullable: false),
                    Person2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => new { x.Person1Id, x.Person2Id });
                    table.ForeignKey(
                        name: "FK_Friends_Users_Person1Id",
                        column: x => x.Person1Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Friends_Users_Person2Id",
                        column: x => x.Person2Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_LikesPosts_Post_RatingPersonId",
                        column: x => x.RatingPersonId,
                        principalTable: "Post",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikesPosts_Users_RatingPersonId",
                        column: x => x.RatingPersonId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersPosts",
                columns: table => new
                {
                    OwnerId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPosts", x => new { x.OwnerId, x.PostId });
                    table.ForeignKey(
                        name: "FK_UsersPosts_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersPosts_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_Person2Id",
                table: "Friends",
                column: "Person2Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsersPosts_PostId",
                table: "UsersPosts",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "LikesPosts");

            migrationBuilder.DropTable(
                name: "UsersPosts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}
