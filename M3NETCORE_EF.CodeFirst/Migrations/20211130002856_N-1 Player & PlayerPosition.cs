using Microsoft.EntityFrameworkCore.Migrations;

namespace M3NETCORE_EF.CodeFirst.Migrations
{
    public partial class N1PlayerPlayerPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerPositionId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_PlayerPositionId",
                table: "Player",
                column: "PlayerPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_PlayerPosition_PlayerPositionId",
                table: "Player",
                column: "PlayerPositionId",
                principalTable: "PlayerPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_PlayerPosition_PlayerPositionId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PlayerPositionId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PlayerPositionId",
                table: "Player");
        }
    }
}
