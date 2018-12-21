using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class mig21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppointmentDrutation",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BillingAmmount",
                table: "Appointments",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDrutation",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "BillingAmmount",
                table: "Appointments");
        }
    }
}
