using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updated_seedData_CustomerPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Password",
                value: "2345");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Password",
                value: "6789");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 46, 13, 985, DateTimeKind.Local).AddTicks(9682));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Password",
                value: "5678");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Password",
                value: "9101112");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1093));
        }
    }
}
