using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addContacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "TContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomPreContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel1Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel2Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail1Coontact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail2Coontact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActifContact = table.Column<bool>(type: "bit", nullable: false),
                    individuId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TContacts_TIndividus_individuId",
                        column: x => x.individuId,
                        principalTable: "TIndividus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TContacts_individuId",
                table: "TContacts",
                column: "individuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TContacts");

           
        }
    }
}
