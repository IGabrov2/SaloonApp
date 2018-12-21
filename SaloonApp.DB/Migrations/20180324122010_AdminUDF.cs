using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class AdminUDF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcedireUDF",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentUDFChek1Amount = table.Column<decimal>(nullable: false),
                    AppointmentUDFChek1Enabled = table.Column<bool>(nullable: false),
                    AppointmentUDFChek1Label = table.Column<string>(nullable: true),
                    AppointmentUDFChek1Time = table.Column<int>(nullable: false),
                    AppointmentUDFChek2Amount = table.Column<decimal>(nullable: false),
                    AppointmentUDFChek2Enabled = table.Column<bool>(nullable: false),
                    AppointmentUDFChek2Label = table.Column<string>(nullable: true),
                    AppointmentUDFChek2Time = table.Column<int>(nullable: false),
                    AppointmentUDFChek3Amount = table.Column<decimal>(nullable: false),
                    AppointmentUDFChek3Enabled = table.Column<bool>(nullable: false),
                    AppointmentUDFChek3Label = table.Column<string>(nullable: true),
                    AppointmentUDFChek3Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedireUDF", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcedireUDF");
        }
    }
}
