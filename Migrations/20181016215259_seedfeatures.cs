using Microsoft.EntityFrameworkCore.Migrations;

namespace angulardotnet.Migrations
{
    public partial class seedfeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("INSERT INTO features (name) VALUES ('Feature1')");
migrationBuilder.Sql("INSERT INTO features (name) VALUES ('Feature2')");
migrationBuilder.Sql("INSERT INTO features (name) VALUES ('Feature3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("DELETE FROM Features WHERE name IN ('Feature1', 'Feature2', 'Feature3')");
        }
    }
}
