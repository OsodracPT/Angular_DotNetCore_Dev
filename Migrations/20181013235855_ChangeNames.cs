using Microsoft.EntityFrameworkCore.Migrations;

namespace angulardotnet.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_models_makes_MakeId",
                table: "models");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "models",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MakeId",
                table: "models",
                newName: "makeid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "models",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_models_MakeId",
                table: "models",
                newName: "IX_models_makeid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "makes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "makes",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_models_makes_makeid",
                table: "models",
                column: "makeid",
                principalTable: "makes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_models_makes_makeid",
                table: "models");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "models",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "makeid",
                table: "models",
                newName: "MakeId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "models",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_models_makeid",
                table: "models",
                newName: "IX_models_MakeId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "makes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "makes",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_models_makes_MakeId",
                table: "models",
                column: "MakeId",
                principalTable: "makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
