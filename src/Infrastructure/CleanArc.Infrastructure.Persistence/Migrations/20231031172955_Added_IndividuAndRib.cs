using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Added_IndividuAndRib : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TIndividus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypDocIdInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumDocIdInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieuDocIdInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDocIdInd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodTvaInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatNaissCreat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GrpInd = table.Column<bool>(type: "bit", nullable: true),
                    LimCredGloInd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LimFinGloInd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InfoInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatInfoInd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdNldp = table.Column<int>(type: "int", nullable: true),
                    CodSclas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbrvInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MfInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RcInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExoTva = table.Column<bool>(type: "bit", nullable: true),
                    DatDebExo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatFinExo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TelInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefAdhInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromJurInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExoInd = table.Column<bool>(type: "bit", nullable: true),
                    AdrInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefAchInd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIndividus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TRibs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RibRib = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActifRib = table.Column<bool>(type: "bit", nullable: false),
                    IndId = table.Column<int>(type: "int", nullable: false),
                    individuId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRibs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRibs_TIndividus_individuId",
                        column: x => x.individuId,
                        principalTable: "TIndividus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRibs_individuId",
                table: "TRibs",
                column: "individuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRibs");

            migrationBuilder.DropTable(
                name: "TIndividus");
        }
    }
}
