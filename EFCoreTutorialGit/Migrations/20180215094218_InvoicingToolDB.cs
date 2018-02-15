using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFCoreTutorialGit.Migrations
{
    public partial class InvoicingToolDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceSchedule",
                columns: table => new
                {
                    InvoiceSchedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReferenceNo = table.Column<string>(nullable: true),
                    SchedEndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    SchedStartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ScheduleName = table.Column<string>(nullable: true),
                    ScheduleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceSchedule", x => x.InvoiceSchedId);
                });

            migrationBuilder.CreateTable(
                name: "Mail",
                columns: table => new
                {
                    MailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsHTML = table.Column<bool>(nullable: false),
                    IsSent = table.Column<bool>(nullable: false),
                    MailBody = table.Column<string>(nullable: true),
                    MailSubject = table.Column<string>(nullable: true),
                    MailTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail", x => x.MailId);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<float>(nullable: false),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    InvoiceName = table.Column<string>(nullable: true),
                    InvoiceSchedId = table.Column<int>(nullable: false),
                    IsAccured = table.Column<bool>(nullable: false),
                    MailId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoice_InvoiceSchedule_InvoiceSchedId",
                        column: x => x.InvoiceSchedId,
                        principalTable: "InvoiceSchedule",
                        principalColumn: "InvoiceSchedId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Mail_MailId",
                        column: x => x.MailId,
                        principalTable: "Mail",
                        principalColumn: "MailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_InvoiceSchedId",
                table: "Invoice",
                column: "InvoiceSchedId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_MailId",
                table: "Invoice",
                column: "MailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "InvoiceSchedule");

            migrationBuilder.DropTable(
                name: "Mail");
        }
    }
}
