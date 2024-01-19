using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Changed_CustomerModel_RegistrationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "TransactionDate",
                value: new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9839));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Customers");

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
    }
}
