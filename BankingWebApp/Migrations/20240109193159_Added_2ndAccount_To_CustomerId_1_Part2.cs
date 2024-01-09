using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Added_2ndAccount_To_CustomerId_1_Part2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "Balance",
                value: 66000.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "Balance",
                value: 89500.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "Balance",
                value: 144000.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                column: "Balance",
                value: 25500.00m);

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

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "ReceiverAccountId", "SenderAccountId", "TransactionDate" },
                values: new object[,]
                {
                    { 11, 3000m, 4, 2, new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1105) },
                    { 12, 15000m, 1, 3, new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1111) },
                    { 13, 6000m, 4, 1, new DateTime(2024, 1, 9, 19, 31, 59, 97, DateTimeKind.Local).AddTicks(1093) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "Balance",
                value: 57000.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "Balance",
                value: 92500.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "Balance",
                value: 159000.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                column: "Balance",
                value: 16500.00m);

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5291));
        }
    }
}
