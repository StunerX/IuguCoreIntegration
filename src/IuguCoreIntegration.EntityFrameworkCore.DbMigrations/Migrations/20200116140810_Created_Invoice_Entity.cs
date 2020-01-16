using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IuguCoreIntegration.Migrations
{
    public partial class Created_Invoice_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Error = table.Column<string>(nullable: true),
                    Success = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Pdf = table.Column<string>(nullable: true),
                    InvoiceId = table.Column<string>(nullable: true),
                    LR = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
