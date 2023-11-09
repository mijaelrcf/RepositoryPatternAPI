using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryPatternAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "CreationDate" },
                values: new object[,]
                {
                    { new Guid("bb2dbef0-0012-4a09-942b-b3c8c1063ddf"), 201000002, new DateTime(2023, 11, 9, 17, 29, 56, 24, DateTimeKind.Local).AddTicks(6157) },
                    { new Guid("d13ce4bf-7d58-407f-8a2d-22c7db3acd53"), 201000001, new DateTime(2023, 11, 9, 17, 29, 56, 24, DateTimeKind.Local).AddTicks(6147) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreationDate", "Email", "Name" },
                values: new object[] { new Guid("7b1fdcfb-6500-46ed-991a-1c1e2450251d"), "Street 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mijael.rcf@gmail", "Mijael Callejas" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "AccountId", "CardNumber", "CreationDate" },
                values: new object[,]
                {
                    { new Guid("2852414c-0c75-4357-ba2d-1fa145203f33"), new Guid("d13ce4bf-7d58-407f-8a2d-22c7db3acd53"), 700000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfef36f9-445c-4e53-b880-63f7d45c1060"), new Guid("bb2dbef0-0012-4a09-942b-b3c8c1063ddf"), 700000002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Amount", "CreationDate", "TransactionDate", "Type" },
                values: new object[,]
                {
                    { new Guid("0f4dcd2c-a06e-44da-8fbe-bdb4fd5e478f"), new Guid("bb2dbef0-0012-4a09-942b-b3c8c1063ddf"), 150.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 17, 29, 56, 24, DateTimeKind.Local).AddTicks(6218), "D" },
                    { new Guid("37f9f422-d0e9-43b8-8edc-a61709f91535"), new Guid("d13ce4bf-7d58-407f-8a2d-22c7db3acd53"), 100.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 17, 29, 56, 24, DateTimeKind.Local).AddTicks(6211), "D" },
                    { new Guid("51e3add7-ce46-492c-92c7-4b48b9c6163f"), new Guid("bb2dbef0-0012-4a09-942b-b3c8c1063ddf"), 350.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 17, 29, 56, 24, DateTimeKind.Local).AddTicks(6222), "C" },
                    { new Guid("82e8796c-6714-433c-83f3-9bda358104b2"), new Guid("d13ce4bf-7d58-407f-8a2d-22c7db3acd53"), 200.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 17, 29, 56, 24, DateTimeKind.Local).AddTicks(6215), "C" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2852414c-0c75-4357-ba2d-1fa145203f33"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("cfef36f9-445c-4e53-b880-63f7d45c1060"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7b1fdcfb-6500-46ed-991a-1c1e2450251d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0f4dcd2c-a06e-44da-8fbe-bdb4fd5e478f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("37f9f422-d0e9-43b8-8edc-a61709f91535"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("51e3add7-ce46-492c-92c7-4b48b9c6163f"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("82e8796c-6714-433c-83f3-9bda358104b2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bb2dbef0-0012-4a09-942b-b3c8c1063ddf"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d13ce4bf-7d58-407f-8a2d-22c7db3acd53"));
        }
    }
}
