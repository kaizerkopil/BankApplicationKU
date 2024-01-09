using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Changed_Logic__Account_TransactionDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 16, 23, 47, 945, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 16, 23, 47, 945, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 16, 23, 47, 945, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 16, 23, 47, 945, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 16, 23, 47, 945, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 16, 23, 47, 945, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 16, 23, 47, 945, DateTimeKind.Local).AddTicks(7313));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionDate",
                table: "Transactions");
        }
    }
}
