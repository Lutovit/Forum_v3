using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class adding_avatars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "1b445257-11b9-4c7a-96c4-06cab4434cd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9zxb-4bb9-9fca-30b01540f173",
                column: "ConcurrencyStamp",
                value: "9e83c16f-2d77-4745-90bb-dc11b7251da4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a16ce9c0-aa65-4af8-bd17-00bd7213e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "172ae2c3-3e5d-4fe7-8ebc-c41b4b2766d8", new DateTime(2021, 9, 10, 21, 55, 6, 989, DateTimeKind.Local).AddTicks(9489), "AQAAAAEAACcQAAAAEIIkk+hCCGn8einFTiNc/eusyKzI7sFY8Nb2iyBVVJOss1WmZP6YvCkZ+7JA7+3u5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a17be9c0-aa65-4af8-bd17-00bd9443e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "eb581bc1-5b2b-48e1-adff-63d7e944b3bb", new DateTime(2021, 9, 10, 21, 55, 6, 983, DateTimeKind.Local).AddTicks(9934), "AQAAAAEAACcQAAAAEGH3cb5f8x3RwT/oAaMOLq+zcaPoq9Ga95jJurfQZn97KS8vAR0Y7JP+0hocP0DW0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "DateOfRegistration", "PasswordHash" },
                values: new object[] { "f94ca394-7513-45fb-b62e-0e526aa4c3fb", new DateTime(2021, 9, 10, 21, 55, 6, 977, DateTimeKind.Local).AddTicks(9484), "AQAAAAEAACcQAAAAEBBCHNeEcchywffeCEQFGkgvctkMwQvZh+o04JZHpvHx8bEUatxce9i2GZ50/QmTQw==" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5127), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5564), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5568), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5714), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5719), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5723), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5750), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5754), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "DateOfLastEdit" },
                values: new object[] { new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5758), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(2799));
        }
    }
}
