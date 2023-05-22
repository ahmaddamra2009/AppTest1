using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppTest1.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    CitizenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DBRNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfBorn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BODText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Side = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eliminate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Governorate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentOfHealth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.CitizenId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}
