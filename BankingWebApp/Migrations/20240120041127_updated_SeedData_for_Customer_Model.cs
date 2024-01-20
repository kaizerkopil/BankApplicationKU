using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updated_SeedData_for_Customer_Model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phonenum",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "City", "PostCode", "RegistrationDate", "StreetAddress" },
                values: new object[] { "Turkey", "T123 555", new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(2876), "John 123 G" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "City", "PostCode", "RegistrationDate", "StreetAddress" },
                values: new object[] { "New Zealand", "NZ12 X55", new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(2947), "Pattrick 456 G" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "City", "PostCode", "RegistrationDate", "StreetAddress" },
                values: new object[] { "Colambia", "CL5 53X", new DateTime(2024, 1, 20, 4, 11, 26, 920, DateTimeKind.Local).AddTicks(2951), "Lilliana 789 X" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Phonenum",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "City", "PostCode", "RegistrationDate", "StreetAddress" },
                values: new object[] { null, null, new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9524), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "City", "PostCode", "RegistrationDate", "StreetAddress" },
                values: new object[] { null, null, new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9596), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "City", "PostCode", "RegistrationDate", "StreetAddress" },
                values: new object[] { null, null, new DateTime(2024, 1, 18, 21, 22, 25, 352, DateTimeKind.Local).AddTicks(9599), null });

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
    }
}
