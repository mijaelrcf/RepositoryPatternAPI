using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryPatternAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreationDate", "Email", "Name" },
                values: new object[] { new Guid("14b579b9-1eef-4bc6-8c36-881c1e9583c0"), "Street 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mijael.rcf@gmail", "Mijael Callejas" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "CreationDate", "CustomerId" },
                values: new object[,]
                {
                    { new Guid("5c3c785f-7299-4733-90ee-276ddda46d71"), 201000002, new DateTime(2023, 11, 10, 11, 18, 41, 904, DateTimeKind.Local).AddTicks(3159), new Guid("14b579b9-1eef-4bc6-8c36-881c1e9583c0") },
                    { new Guid("c3f6784d-329c-4f30-9b1c-e808a74a4241"), 201000001, new DateTime(2023, 11, 10, 11, 18, 41, 904, DateTimeKind.Local).AddTicks(3147), new Guid("14b579b9-1eef-4bc6-8c36-881c1e9583c0") }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "AccountId", "CardNumber", "CreationDate" },
                values: new object[,]
                {
                    { new Guid("2965478f-c14c-4f20-8204-727ccca8da59"), new Guid("c3f6784d-329c-4f30-9b1c-e808a74a4241"), 700000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66354dfb-1e4a-4286-a889-d1d89ba2c2d8"), new Guid("5c3c785f-7299-4733-90ee-276ddda46d71"), 700000002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountId", "Amount", "CardNumber", "CreationDate", "TransactionDate", "Type" },
                values: new object[,]
                {
                    { new Guid("0600c3a2-2cf2-4aa8-955d-c8c2629da073"), new Guid("c3f6784d-329c-4f30-9b1c-e808a74a4241"), 100.0, 700000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 11, 18, 41, 904, DateTimeKind.Local).AddTicks(3221), "D" },
                    { new Guid("10da1618-5f14-45b5-bfd1-4501f2d43d3c"), new Guid("5c3c785f-7299-4733-90ee-276ddda46d71"), 350.0, 700000002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 11, 18, 41, 904, DateTimeKind.Local).AddTicks(3232), "C" },
                    { new Guid("d8a78ade-0905-4d7a-b8d8-9194ca972ca1"), new Guid("c3f6784d-329c-4f30-9b1c-e808a74a4241"), 200.0, 700000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 11, 18, 41, 904, DateTimeKind.Local).AddTicks(3225), "C" },
                    { new Guid("f00bf369-5382-4138-9824-fb7604227944"), new Guid("5c3c785f-7299-4733-90ee-276ddda46d71"), 150.0, 700000002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 11, 18, 41, 904, DateTimeKind.Local).AddTicks(3228), "D" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2965478f-c14c-4f20-8204-727ccca8da59"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("66354dfb-1e4a-4286-a889-d1d89ba2c2d8"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("0600c3a2-2cf2-4aa8-955d-c8c2629da073"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("10da1618-5f14-45b5-bfd1-4501f2d43d3c"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("d8a78ade-0905-4d7a-b8d8-9194ca972ca1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f00bf369-5382-4138-9824-fb7604227944"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5c3c785f-7299-4733-90ee-276ddda46d71"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c3f6784d-329c-4f30-9b1c-e808a74a4241"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("14b579b9-1eef-4bc6-8c36-881c1e9583c0"));
        }
    }
}
