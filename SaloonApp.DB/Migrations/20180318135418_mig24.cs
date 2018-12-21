using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class mig24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProcedure",
                table: "ProceduresSettings",
                newName: "IdProceduresSettings");

            migrationBuilder.AlterColumn<bool>(
                name: "Male",
                table: "ProceduresSettings",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProceduresSettings",
                table: "ProceduresSettings",
                newName: "IdProcedure");

            migrationBuilder.AlterColumn<int>(
                name: "Male",
                table: "ProceduresSettings",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
