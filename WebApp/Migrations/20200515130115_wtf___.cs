using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class wtf___ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Posts",
                table: "UserModels");

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "PostModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostModel_UserModelId",
                table: "PostModel",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostModel_UserModels_UserModelId",
                table: "PostModel",
                column: "UserModelId",
                principalTable: "UserModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostModel_UserModels_UserModelId",
                table: "PostModel");

            migrationBuilder.DropIndex(
                name: "IX_PostModel_UserModelId",
                table: "PostModel");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "PostModel");

            migrationBuilder.AddColumn<int[]>(
                name: "Posts",
                table: "UserModels",
                type: "integer[]",
                nullable: true);
        }
    }
}
