using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class AdminUDF7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentUDF10Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF10Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF1Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF1Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF2Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF2Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF3Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF3Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF4Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF4Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF5Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF5Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF6Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF6Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF7Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF7Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF8Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF8Time",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF9Amount",
                table: "AppointmentProcedureUDF");

            migrationBuilder.DropColumn(
                name: "AppointmentUDF9Time",
                table: "AppointmentProcedureUDF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF10Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF10Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF1Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF1Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF2Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF2Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF3Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF3Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF4Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF4Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF5Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF5Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF6Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF6Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF7Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF7Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF8Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF8Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF9Amount",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentUDF9Time",
                table: "AppointmentProcedureUDF",
                nullable: false,
                defaultValue: 0);
        }
    }
}
