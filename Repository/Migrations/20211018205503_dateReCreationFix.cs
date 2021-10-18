using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class dateReCreationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "30d561ff-5350-4b43-a045-9f09c2ff3918");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9zxb-4bb9-9fca-30b01540f173",
                column: "ConcurrencyStamp",
                value: "6bdd8c37-5a47-4c66-b4f6-738f67cec75f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "13140f77-363a-4626-9d2b-39d0dbab4799", new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(328), "AQAAAAEAACcQAAAAELyF3pu9Tiz1lst/jbMnBaK1FpXw6STYWdeFxGPGOaUg0BltLP5y5lxZ1NI0RqaDsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "20abdb23-b162-4d73-927a-cc991de7655b", new DateTime(2021, 10, 18, 23, 55, 2, 624, DateTimeKind.Local).AddTicks(540), "AQAAAAEAACcQAAAAEFB3GnoQaN0sBBiTxLe3lKTMwPsLUFfev0BmNU7mR4/rpSOEpfja4s5m9u4Ax3FiWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "f222406d-db5c-4ee0-b242-4ee8d4d998ce", new DateTime(2021, 10, 18, 23, 55, 2, 617, DateTimeKind.Local).AddTicks(9713), "AQAAAAEAACcQAAAAEAqNhPBSNaQXW3DGE1xWnxytM+t03MdfmcH32+hvNVn6RVYLB/egdR1CmjEF95tF+w==" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(4376), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5756), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5762), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5955), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5960), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5962), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5993), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5996), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5998), new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 18, 23, 55, 2, 630, DateTimeKind.Local).AddTicks(3274));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
