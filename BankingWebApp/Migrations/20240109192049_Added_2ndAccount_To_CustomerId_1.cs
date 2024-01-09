using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Added_2ndAccount_To_CustomerId_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountType", "Balance", "CustomerId" },
                values: new object[] { 4, "Debit", 16500.00m, 1 });

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

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "ReceiverAccountId", "SenderAccountId", "TransactionDate" },
                values: new object[,]
                {
                    { 8, 2000m, 3, 4, new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5287) },
                    { 9, 1500m, 2, 4, new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5289) },
                    { 10, 5000m, 1, 4, new DateTime(2024, 1, 9, 19, 20, 49, 492, DateTimeKind.Local).AddTicks(5291) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "Balance",
                value: 52000.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "Balance",
                value: 91000.00m);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "Balance",
                value: 157000.00m);

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
    }
}
