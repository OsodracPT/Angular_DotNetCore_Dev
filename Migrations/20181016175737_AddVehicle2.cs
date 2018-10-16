using Microsoft.EntityFrameworkCore.Migrations;

namespace angulardotnet.Migrations
{
    public partial class AddVehicle2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFeature_features_featureid",
                table: "VehicleFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFeature_vehicles_vehicleid",
                table: "VehicleFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleFeature",
                table: "VehicleFeature");

            migrationBuilder.DropIndex(
                name: "IX_VehicleFeature_vehicleid",
                table: "VehicleFeature");

            migrationBuilder.DropColumn(
                name: "vehicle_id",
                table: "VehicleFeature");

            migrationBuilder.DropColumn(
                name: "feature_id",
                table: "VehicleFeature");

            migrationBuilder.RenameTable(
                name: "VehicleFeature",
                newName: "vehiclefeatures");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleFeature_featureid",
                table: "vehiclefeatures",
                newName: "IX_vehiclefeatures_featureid");

            migrationBuilder.AlterColumn<int>(
                name: "vehicleid",
                table: "vehiclefeatures",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "featureid",
                table: "vehiclefeatures",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehiclefeatures",
                table: "vehiclefeatures",
                columns: new[] { "vehicleid", "featureid" });

            migrationBuilder.AddForeignKey(
                name: "FK_vehiclefeatures_features_featureid",
                table: "vehiclefeatures",
                column: "featureid",
                principalTable: "features",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiclefeatures_vehicles_vehicleid",
                table: "vehiclefeatures",
                column: "vehicleid",
                principalTable: "vehicles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiclefeatures_features_featureid",
                table: "vehiclefeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiclefeatures_vehicles_vehicleid",
                table: "vehiclefeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehiclefeatures",
                table: "vehiclefeatures");

            migrationBuilder.RenameTable(
                name: "vehiclefeatures",
                newName: "VehicleFeature");

            migrationBuilder.RenameIndex(
                name: "IX_vehiclefeatures_featureid",
                table: "VehicleFeature",
                newName: "IX_VehicleFeature_featureid");

            migrationBuilder.AlterColumn<int>(
                name: "featureid",
                table: "VehicleFeature",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "vehicleid",
                table: "VehicleFeature",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "vehicle_id",
                table: "VehicleFeature",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "feature_id",
                table: "VehicleFeature",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleFeature",
                table: "VehicleFeature",
                columns: new[] { "vehicle_id", "feature_id" });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeature_vehicleid",
                table: "VehicleFeature",
                column: "vehicleid");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFeature_features_featureid",
                table: "VehicleFeature",
                column: "featureid",
                principalTable: "features",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFeature_vehicles_vehicleid",
                table: "VehicleFeature",
                column: "vehicleid",
                principalTable: "vehicles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
