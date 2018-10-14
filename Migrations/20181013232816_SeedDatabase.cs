using Microsoft.EntityFrameworkCore.Migrations;

namespace angulardotnet.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Makes\" (\"Name\") VALUES('Make1')");
            migrationBuilder.Sql("INSERT INTO \"Makes\" (\"Name\") VALUES('Make2')");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Makes\"");

        }
    }
}
