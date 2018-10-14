using Microsoft.EntityFrameworkCore.Migrations;

namespace angulardotnet.Migrations
{
    public partial class ChangeTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makes",
                table: "Makes");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "models");

            migrationBuilder.RenameTable(
                name: "Makes",
                newName: "makes");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MakeId",
                table: "models",
                newName: "IX_models_MakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_models",
                table: "models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_makes",
                table: "makes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_models_makes_MakeId",
                table: "models",
                column: "MakeId",
                principalTable: "makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_models_makes_MakeId",
                table: "models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_models",
                table: "models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_makes",
                table: "makes");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "models",
                newName: "Models");

            migrationBuilder.RenameTable(
                name: "makes",
                newName: "Makes");

            migrationBuilder.RenameIndex(
                name: "IX_models_MakeId",
                table: "Models",
                newName: "IX_Models_MakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makes",
                table: "Makes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
