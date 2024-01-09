using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updated_seedData_CustomerPassword_p2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Password",
                value: "1111");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Password",
                value: "2222");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Password",
                value: "3333");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 22, 47, 31, 563, DateTimeKind.Local).AddTicks(816));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Password",
                value: "1234");

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
    }
}
