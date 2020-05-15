using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApp.Migrations
{
    public partial class PostUpdate : Migration
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
                name: "FK_LikesPosts_Post_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_Post_PostId",
                table: "UsersPosts");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_Person2Id",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Person1Id",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Person2Id",
                table: "Friends");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonInputRequestId",
                table: "Friends",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonOutputRequestId",
                table: "Friends",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                columns: new[] { "PersonInputRequestId", "PersonOutputRequestId" });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Owner = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    senderId = table.Column<int>(nullable: false),
                    targetId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => new { x.senderId, x.targetId });
                    table.ForeignKey(
                        name: "FK_Subscribers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subscribers_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subscribers_Users_senderId",
                        column: x => x.senderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscribers_Users_targetId",
                        column: x => x.targetId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_PersonOutputRequestId",
                table: "Friends",
                column: "PersonOutputRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_UserId",
                table: "Subscribers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_UserId1",
                table: "Subscribers",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_targetId",
                table: "Subscribers",
                column: "targetId");

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
                name: "FK_LikesPosts_Posts_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_Posts_PostId",
                table: "UsersPosts",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_PersonInputRequestId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_PersonOutputRequestId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_LikesPosts_Posts_RatingPersonId",
                table: "LikesPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersPosts_Posts_PostId",
                table: "UsersPosts");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_PersonOutputRequestId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PersonInputRequestId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "PersonOutputRequestId",
                table: "Friends");

            migrationBuilder.AddColumn<int>(
                name: "Person1Id",
                table: "Friends",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Person2Id",
                table: "Friends",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                columns: new[] { "Person1Id", "Person2Id" });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<string>(type: "text", nullable: true),
                    owner = table.Column<int>(type: "integer", nullable: false),
                    rating = table.Column<int>(type: "integer", nullable: false),
                    text = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_Person2Id",
                table: "Friends",
                column: "Person2Id");

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
                name: "FK_LikesPosts_Post_RatingPersonId",
                table: "LikesPosts",
                column: "RatingPersonId",
                principalTable: "Post",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersPosts_Post_PostId",
                table: "UsersPosts",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
