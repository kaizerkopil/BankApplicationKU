using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 8, 26, 16, 737, DateTimeKind.Local).AddTicks(2182));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6694));
        }
    }
}
