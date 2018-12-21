using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class AdminUDF2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AppointmentUDFChek3Amount",
                table: "ProcedireUDF",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentUDFChek2Amount",
                table: "ProcedireUDF",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentUDFChek1Amount",
                table: "ProcedireUDF",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "AppointmentUDFChek3Amount",
                table: "ProcedireUDF",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "AppointmentUDFChek2Amount",
                table: "ProcedireUDF",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "AppointmentUDFChek1Amount",
                table: "ProcedireUDF",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
