using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFCoreTutorialGit.Migrations
{
    public partial class InvoiceDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Mail_MailId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_MailId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "MailId",
                table: "Invoice");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceSchedId",
                table: "Mail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MailId",
                table: "InvoiceSchedule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MailId1",
                table: "InvoiceSchedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mail_InvoiceSchedId",
                table: "Mail",
                column: "InvoiceSchedId",
                unique: true,
                filter: "[InvoiceSchedId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceSchedule_MailId1",
                table: "InvoiceSchedule",
                column: "MailId1");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceSchedule_Mail_MailId1",
                table: "InvoiceSchedule",
                column: "MailId1",
                principalTable: "Mail",
                principalColumn: "MailId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mail_InvoiceSchedule_InvoiceSchedId",
                table: "Mail",
                column: "InvoiceSchedId",
                principalTable: "InvoiceSchedule",
                principalColumn: "InvoiceSchedId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceSchedule_Mail_MailId1",
                table: "InvoiceSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Mail_InvoiceSchedule_InvoiceSchedId",
                table: "Mail");

            migrationBuilder.DropIndex(
                name: "IX_Mail_InvoiceSchedId",
                table: "Mail");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceSchedule_MailId1",
                table: "InvoiceSchedule");

            migrationBuilder.DropColumn(
                name: "InvoiceSchedId",
                table: "Mail");

            migrationBuilder.DropColumn(
                name: "MailId",
                table: "InvoiceSchedule");

            migrationBuilder.DropColumn(
                name: "MailId1",
                table: "InvoiceSchedule");

            migrationBuilder.AddColumn<int>(
                name: "MailId",
                table: "Invoice",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_MailId",
                table: "Invoice",
                column: "MailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Mail_MailId",
                table: "Invoice",
                column: "MailId",
                principalTable: "Mail",
                principalColumn: "MailId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
