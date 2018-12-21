using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class AdminUDF3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek10Amount",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AppointmentUDFChek10Enabled",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentUDFChek10Label",
                table: "ProcedireUDF",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek10Time",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek4Amount",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AppointmentUDFChek4Enabled",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentUDFChek4Label",
                table: "ProcedireUDF",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek4Time",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek5Amount",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AppointmentUDFChek5Enabled",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentUDFChek5Label",
                table: "ProcedireUDF",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek5Time",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek6Amount",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AppointmentUDFChek6Enabled",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentUDFChek6Label",
                table: "ProcedireUDF",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek6Time",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek7Amount",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AppointmentUDFChek7Enabled",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentUDFChek7Label",
                table: "ProcedireUDF",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek7Time",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek8Amount",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AppointmentUDFChek8Enabled",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentUDFChek8Label",
                table: "ProcedireUDF",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek8Time",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek9Amount",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AppointmentUDFChek9Enabled",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentUDFChek9Label",
                table: "ProcedireUDF",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDFChek9Time",
                table: "ProcedireUDF",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek10Amount",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek10Enabled",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek10Label",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek10Time",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek4Amount",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek4Enabled",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek4Label",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek4Time",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek5Amount",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek5Enabled",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek5Label",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek5Time",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek6Amount",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek6Enabled",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek6Label",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek6Time",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek7Amount",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek7Enabled",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek7Label",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek7Time",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek8Amount",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek8Enabled",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek8Label",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek8Time",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek9Amount",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek9Enabled",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek9Label",
                table: "ProcedireUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDFChek9Time",
                table: "ProcedireUDF");
        }
    }
}
