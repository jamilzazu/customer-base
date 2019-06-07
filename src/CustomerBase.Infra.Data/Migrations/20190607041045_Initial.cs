using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerBase.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    Document = table.Column<string>(type: "varchar(150)", nullable: true),
                    Email = table.Column<string>(type: "varchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(150)", nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
