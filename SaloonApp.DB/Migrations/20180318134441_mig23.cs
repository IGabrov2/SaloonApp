using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaloonApp.DB.Migrations
{
    public partial class mig23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProceduresSettings",
                columns: table => new
                {
                    IdProcedure = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmountForBlowing = table.Column<int>(nullable: false),
                    AmountForDying = table.Column<int>(nullable: false),
                    AmountForHairCut = table.Column<int>(nullable: false),
                    AmountForHairstyle = table.Column<int>(nullable: false),
                    AmountForMakeUp = table.Column<int>(nullable: false),
                    AmountForManicure = table.Column<int>(nullable: false),
                    AmountForPartialDying = table.Column<int>(nullable: false),
                    AmountForPedicure = table.Column<int>(nullable: false),
                    AmountForWashing = table.Column<int>(nullable: false),
                    DurationForBlowing = table.Column<int>(nullable: false),
                    DurationForDying = table.Column<int>(nullable: false),
                    DurationForHairCut = table.Column<int>(nullable: false),
                    DurationForHairstyle = table.Column<int>(nullable: false),
                    DurationForMakeUp = table.Column<int>(nullable: false),
                    DurationForManicure = table.Column<int>(nullable: false),
                    DurationForPartialDying = table.Column<int>(nullable: false),
                    DurationForPedicure = table.Column<int>(nullable: false),
                    DurationForWashing = table.Column<int>(nullable: false),
                    Male = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProceduresSettings", x => x.IdProcedure);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProceduresSettings");
        }
    }
}
