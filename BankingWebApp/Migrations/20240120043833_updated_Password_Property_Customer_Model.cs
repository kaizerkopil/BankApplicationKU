using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updated_Password_Property_Customer_Model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Password", "RegistrationDate" },
                values: new object[] { "11111", new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Password", "RegistrationDate" },
                values: new object[] { "22222", new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Password", "RegistrationDate" },
                values: new object[] { "33333", new DateTime(2024, 1, 20, 4, 38, 33, 10, DateTimeKind.Local).AddTicks(6454) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Password", "RegistrationDate" },
                values: new object[] { "1111", new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Password", "RegistrationDate" },
                values: new object[] { "2222", new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Password", "RegistrationDate" },
                values: new object[] { "3333", new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(3202));
        }
    }
}
