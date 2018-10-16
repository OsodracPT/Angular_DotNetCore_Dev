using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace angulardotnet.Migrations
{
    public partial class AddVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    model_id = table.Column<int>(nullable: false),
                    modelid = table.Column<int>(nullable: true),
                    is_registered = table.Column<bool>(nullable: false),
                    contact_name = table.Column<string>(maxLength: 255, nullable: false),
                    contact_email = table.Column<string>(maxLength: 255, nullable: true),
                    contact_phone = table.Column<string>(maxLength: 255, nullable: false),
                    last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.id);
                    table.ForeignKey(
                        name: "FK_vehicles_models_modelid",
                        column: x => x.modelid,
                        principalTable: "models",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleFeature",
                columns: table => new
                {
                    vehicle_id = table.Column<int>(nullable: false),
                    feature_id = table.Column<int>(nullable: false),
                    vehicleid = table.Column<int>(nullable: true),
                    featureid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFeature", x => new { x.vehicle_id, x.feature_id });
                    table.ForeignKey(
                        name: "FK_VehicleFeature_features_featureid",
                        column: x => x.featureid,
                        principalTable: "features",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleFeature_vehicles_vehicleid",
                        column: x => x.vehicleid,
                        principalTable: "vehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeature_featureid",
                table: "VehicleFeature",
                column: "featureid");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeature_vehicleid",
                table: "VehicleFeature",
                column: "vehicleid");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_modelid",
                table: "vehicles",
                column: "modelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleFeature");

            migrationBuilder.DropTable(
                name: "vehicles");
        }
    }
}
