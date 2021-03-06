﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class AdminUDF6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentUDF_AppointmentUDFID",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentUDF");

            migrationBuilder.CreateTable(
                name: "AppointmentProcedureUDF",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentUDF10Amount = table.Column<int>(nullable: false),
                    AppointmentUDF10Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF10Time = table.Column<int>(nullable: false),
                    AppointmentUDF1Amount = table.Column<int>(nullable: false),
                    AppointmentUDF1Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF1Time = table.Column<int>(nullable: false),
                    AppointmentUDF2Amount = table.Column<int>(nullable: false),
                    AppointmentUDF2Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF2Time = table.Column<int>(nullable: false),
                    AppointmentUDF3Amount = table.Column<int>(nullable: false),
                    AppointmentUDF3Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF3Time = table.Column<int>(nullable: false),
                    AppointmentUDF4Amount = table.Column<int>(nullable: false),
                    AppointmentUDF4Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF4Time = table.Column<int>(nullable: false),
                    AppointmentUDF5Amount = table.Column<int>(nullable: false),
                    AppointmentUDF5Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF5Time = table.Column<int>(nullable: false),
                    AppointmentUDF6Amount = table.Column<int>(nullable: false),
                    AppointmentUDF6Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF6Time = table.Column<int>(nullable: false),
                    AppointmentUDF7Amount = table.Column<int>(nullable: false),
                    AppointmentUDF7Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF7Time = table.Column<int>(nullable: false),
                    AppointmentUDF8Amount = table.Column<int>(nullable: false),
                    AppointmentUDF8Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF8Time = table.Column<int>(nullable: false),
                    AppointmentUDF9Amount = table.Column<int>(nullable: false),
                    AppointmentUDF9Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF9Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentProcedureUDF", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentProcedureUDF_AppointmentUDFID",
                table: "Appointments",
                column: "AppointmentUDFID",
                principalTable: "AppointmentProcedureUDF",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentProcedureUDF_AppointmentUDFID",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentProcedureUDF");

            migrationBuilder.CreateTable(
                name: "AppointmentUDF",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentUDF10Amount = table.Column<int>(nullable: false),
                    AppointmentUDF10Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF10Time = table.Column<int>(nullable: false),
                    AppointmentUDF1Amount = table.Column<int>(nullable: false),
                    AppointmentUDF1Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF1Time = table.Column<int>(nullable: false),
                    AppointmentUDF2Amount = table.Column<int>(nullable: false),
                    AppointmentUDF2Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF2Time = table.Column<int>(nullable: false),
                    AppointmentUDF3Amount = table.Column<int>(nullable: false),
                    AppointmentUDF3Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF3Time = table.Column<int>(nullable: false),
                    AppointmentUDF4Amount = table.Column<int>(nullable: false),
                    AppointmentUDF4Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF4Time = table.Column<int>(nullable: false),
                    AppointmentUDF5Amount = table.Column<int>(nullable: false),
                    AppointmentUDF5Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF5Time = table.Column<int>(nullable: false),
                    AppointmentUDF6Amount = table.Column<int>(nullable: false),
                    AppointmentUDF6Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF6Time = table.Column<int>(nullable: false),
                    AppointmentUDF7Amount = table.Column<int>(nullable: false),
                    AppointmentUDF7Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF7Time = table.Column<int>(nullable: false),
                    AppointmentUDF8Amount = table.Column<int>(nullable: false),
                    AppointmentUDF8Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF8Time = table.Column<int>(nullable: false),
                    AppointmentUDF9Amount = table.Column<int>(nullable: false),
                    AppointmentUDF9Checked = table.Column<bool>(nullable: false),
                    AppointmentUDF9Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentUDF", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentUDF_AppointmentUDFID",
                table: "Appointments",
                column: "AppointmentUDFID",
                principalTable: "AppointmentUDF",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
