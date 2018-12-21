using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class dsadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdHairDresser",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProcedures",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdHairDresser",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IdProcedures",
                table: "Appointments");
        }
    }
}
