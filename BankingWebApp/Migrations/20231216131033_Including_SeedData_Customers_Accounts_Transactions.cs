using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Including_SeedData_Customers_Accounts_Transactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "EmailAddress", "FirstName", "LastName", "Phonenum", "PostCode", "StreetAddress" },
                values: new object[,]
                {
                    { 1, null, "john.gerrad@gmail.com", "John", "Gerrad", "07705089501", null, null },
                    { 2, null, "pattrick.george@outlook.com", "Pattrick", "George", "07755589511", null, null },
                    { 3, null, "lilliana.bestie@hotmail.com", "Lilliana", "Johnson", "07712312355", null, null }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "Balance", "CustomerId" },
                values: new object[,]
                {
                    { 1, 52000.00m, 1 },
                    { 2, 91000.00m, 2 },
                    { 3, 157000.00m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "ReceiverAccountId", "SenderAccountId" },
                values: new object[,]
                {
                    { 1, 1000m, 2, 1 },
                    { 2, 3000m, 2, 1 },
                    { 3, 5000m, 3, 1 },
                    { 4, 6000m, 1, 2 },
                    { 5, 15000m, 3, 2 },
                    { 6, 5000m, 1, 3 },
                    { 7, 8000m, 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);
        }
    }
}
