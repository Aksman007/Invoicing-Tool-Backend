using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFCoreTutorialGit.Migrations
{
    public partial class InvoiceDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Mail_MailId",
                table: "Invoice");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSent",
                table: "Mail",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsHTML",
                table: "Mail",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SchedStartDate",
                table: "InvoiceSchedule",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SchedEndDate",
                table: "InvoiceSchedule",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<int>(
                name: "MailId",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsAccured",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceSchedId",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Mail_MailId",
                table: "Invoice",
                column: "MailId",
                principalTable: "Mail",
                principalColumn: "MailId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Mail_MailId",
                table: "Invoice");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSent",
                table: "Mail",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsHTML",
                table: "Mail",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SchedStartDate",
                table: "InvoiceSchedule",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SchedEndDate",
                table: "InvoiceSchedule",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MailId",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAccured",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceSchedId",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "Invoice",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Mail_MailId",
                table: "Invoice",
                column: "MailId",
                principalTable: "Mail",
                principalColumn: "MailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
