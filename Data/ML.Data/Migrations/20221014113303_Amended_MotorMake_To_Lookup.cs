using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ML.Data.Migrations
{
    public partial class Amended_MotorMake_To_Lookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotorTypeId",
                table: "MotorMakes");

            migrationBuilder.AddColumn<int>(
                name: "MotorTypeId",
                table: "MotorModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MotorTypeId",
                table: "MotorModels");

            migrationBuilder.AddColumn<int>(
                name: "MotorTypeId",
                table: "MotorMakes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
