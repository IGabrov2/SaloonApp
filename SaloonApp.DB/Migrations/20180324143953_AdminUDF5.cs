using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class AdminUDF5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentUDF10Iime",
                table: "AppointmentUDF",
                newName: "AppointmentUDF10Time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentUDF10Time",
                table: "AppointmentUDF",
                newName: "AppointmentUDF10Iime");
        }
    }
}
