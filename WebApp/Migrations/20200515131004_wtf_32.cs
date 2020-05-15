using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class wtf_32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Subscribers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    PersonInputRequestId = table.Column<int>(type: "integer", nullable: false),
                    PersonOutputRequestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => new { x.PersonInputRequestId, x.PersonOutputRequestId });
                    table.ForeignKey(
                        name: "FK_Friends_UserModels_PersonInputRequestId",
                        column: x => x.PersonInputRequestId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Friends_UserModels_PersonOutputRequestId",
                        column: x => x.PersonOutputRequestId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    senderId = table.Column<int>(type: "integer", nullable: false),
                    targetId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => new { x.senderId, x.targetId });
                    table.ForeignKey(
                        name: "FK_Subscribers_UserModels_senderId",
                        column: x => x.senderId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscribers_UserModels_targetId",
                        column: x => x.targetId,
                        principalTable: "UserModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_PersonOutputRequestId",
                table: "Friends",
                column: "PersonOutputRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_targetId",
                table: "Subscribers",
                column: "targetId");
        }
    }
}
