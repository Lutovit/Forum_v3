using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class OrderByDateOflastMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfLastMessage",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "4ff83f6a-438b-4cb7-b8e8-dbbfb07068ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9zxb-4bb9-9fca-30b01540f173",
                column: "ConcurrencyStamp",
                value: "8f642241-da22-4d1b-a129-e7c9b5fadeb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "302f2a21-4a53-4ffc-9933-1541a33cbbca", new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(51), "AQAAAAEAACcQAAAAEL7h9TZuNdNesoskjW7UgDiMt7t+6fos9mEFzWQkZj61OmOvJ+KKtbBDGv47ozLUkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "baa72e81-0e2c-48f7-a344-5bd93800ab80", new DateTime(2021, 10, 18, 23, 28, 50, 846, DateTimeKind.Local).AddTicks(47), "AQAAAAEAACcQAAAAEEnfhuC8hZMUfiFzE1d+YIf7NdzMKO1+tomF52ksm4Vx8YilYFaRQcjzl8reHZmKPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "27be896c-c04b-4d40-8225-4c253ca90d76", new DateTime(2021, 10, 18, 23, 28, 50, 839, DateTimeKind.Local).AddTicks(9246), "AQAAAAEAACcQAAAAEHrGfXc3ZLV9B6XylnoeKjLHo34DUOR+R1rUfXREtw0gVjrT8vJYcigYOfgJ8vR3tA==" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(5689), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6114), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6119), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6348), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6352), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6356), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6387), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6391), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6395), new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 18, 23, 28, 50, 852, DateTimeKind.Local).AddTicks(3418));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfLastMessage",
                table: "Topics");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "72d0a639-4d1a-46c7-bbef-edf7dc9f3e7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9zxb-4bb9-9fca-30b01540f173",
                column: "ConcurrencyStamp",
                value: "d45c85c1-674c-499d-868a-88d2f6479b85");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "4d0e807d-9ede-4d8b-810f-3f79723c656e", new DateTime(2021, 10, 8, 22, 57, 58, 21, DateTimeKind.Local).AddTicks(4916), "AQAAAAEAACcQAAAAELqdayseOoTKIHdVwwCsdG4X0wnaUhzmLK0c/PM1XJg2f4mJjVtR4gwViHa1pfSFFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "a9723af9-c847-4340-97ea-11c9c0f6b0ed", new DateTime(2021, 10, 8, 22, 57, 57, 999, DateTimeKind.Local).AddTicks(7726), "AQAAAAEAACcQAAAAEAnfx2pLa9aTD2kD1Fw3wd8ZzZBhemUR6Qmj7Y6CRImFVF7NxoWXKJusq5ACOjjbLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "ca4c010d-2486-4dc5-b3af-0fcf033601d8", new DateTime(2021, 10, 8, 22, 57, 57, 977, DateTimeKind.Local).AddTicks(9228), "AQAAAAEAACcQAAAAENvaszQsfLf9DL7GfcgzhopjLiiXtzyYC1O+q8P/8ky40OWGP9WAsIZAR0208JL1GA==" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(6182), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7839), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7854), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8450), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8465), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8480), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8585), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8600), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8614), new DateTime(2021, 10, 8, 22, 57, 58, 23, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 8, 22, 57, 58, 22, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 8, 22, 57, 58, 22, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 8, 22, 57, 58, 22, DateTimeKind.Local).AddTicks(7137));
        }
    }
}
