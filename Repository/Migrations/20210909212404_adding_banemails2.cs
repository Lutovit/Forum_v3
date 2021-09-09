using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class adding_banemails2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BanEmails",
                columns: new[] { "Id", "Email" },
                values: new object[] { 3, "user@user3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BanEmails",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
