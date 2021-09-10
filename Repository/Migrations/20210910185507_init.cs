using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isBanned = table.Column<bool>(type: "bit", nullable: false),
                    isDelited = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BanEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TopicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isEdited = table.Column<bool>(type: "bit", nullable: false),
                    isDelited = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isEdited = table.Column<bool>(type: "bit", nullable: false),
                    isDelited = table.Column<bool>(type: "bit", nullable: false),
                    DateOfLastEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "1b445257-11b9-4c7a-96c4-06cab4434cd2", "admin", "ADMIN" },
                    { "ad376a8f-9zxb-4bb9-9fca-30b01540f173", "9e83c16f-2d77-4745-90bb-dc11b7251da4", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ClientName", "CompanyName", "ConcurrencyStamp", "DateOfRegistration", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isBanned", "isDelited" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "Maxim Malakhov", "MaxFunnyApps", "f94ca394-7513-45fb-b62e-0e526aa4c3fb", new DateTime(2021, 9, 10, 21, 55, 6, 977, DateTimeKind.Local).AddTicks(9484), "pilot_mig@bk.ru", false, false, null, "PILOT_MIG@BK.RU", "PILOT_MIG@BK.RU", "AQAAAAEAACcQAAAAEBBCHNeEcchywffeCEQFGkgvctkMwQvZh+o04JZHpvHx8bEUatxce9i2GZ50/QmTQw==", null, false, "", false, "pilot_mig@bk.ru", false, false },
                    { "a17be9c0-aa65-4af8-bd17-00bd9443e575", 0, "Dima Ivanov", "Dima Constractions", "eb581bc1-5b2b-48e1-adff-63d7e944b3bb", new DateTime(2021, 9, 10, 21, 55, 6, 983, DateTimeKind.Local).AddTicks(9934), "diman@bk.ru", false, false, null, "DIMAN@BK.RU", "DIMAN@BK.RU", "AQAAAAEAACcQAAAAEGH3cb5f8x3RwT/oAaMOLq+zcaPoq9Ga95jJurfQZn97KS8vAR0Y7JP+0hocP0DW0w==", null, false, "", false, "diman@bk.ru", true, false },
                    { "a16ce9c0-aa65-4af8-bd17-00bd7213e575", 0, "Sergei Butovo", "Sergio Vine Company", "172ae2c3-3e5d-4fe7-8ebc-c41b4b2766d8", new DateTime(2021, 9, 10, 21, 55, 6, 989, DateTimeKind.Local).AddTicks(9489), "sergio@bk.ru", false, false, null, "SERGIO@BK.RU", "SERGIO@BK.RU", "AQAAAAEAACcQAAAAEIIkk+hCCGn8einFTiNc/eusyKzI7sFY8Nb2iyBVVJOss1WmZP6YvCkZ+7JA7+3u5A==", null, false, "", false, "sergio@bk.ru", false, false }
                });

            migrationBuilder.InsertData(
                table: "BanEmails",
                columns: new[] { "Id", "Email" },
                values: new object[] { 1, "diman@bk.ru" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad376a8f-9eab-4bb9-9fca-30b01540f445", "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { "ad376a8f-9zxb-4bb9-9fca-30b01540f173", "a17be9c0-aa65-4af8-bd17-00bd9443e575" },
                    { "ad376a8f-9zxb-4bb9-9fca-30b01540f173", "a16ce9c0-aa65-4af8-bd17-00bd7213e575" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "ApplicationUserId", "Date", "TopicDescription", "TopicName", "isDelited", "isEdited" },
                values: new object[,]
                {
                    { 1, "a18be9c0-aa65-4af8-bd17-00bd9344e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(2130), "Discussing star ships, their engines and something like this.", "Star ships, interstellars comunications, gelium atomic engines.", false, false },
                    { 2, "a17be9c0-aa65-4af8-bd17-00bd9443e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(2796), "Discussing we spend time during interstellar voyages.", "Vine and sigaretes while you are in deep space.", false, false },
                    { 3, "a16ce9c0-aa65-4af8-bd17-00bd7213e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(2799), "How we do sport, while we are in space.", "Sports in space.", false, false }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ApplicationUserId", "Date", "DateOfLastEdit", "Text", "TopicId", "UserName", "isDelited", "isEdited" },
                values: new object[,]
                {
                    { 1, "a18be9c0-aa65-4af8-bd17-00bd9344e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5127), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5130), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 1, "pilot_mig@bk.ru", false, false },
                    { 2, "a18be9c0-aa65-4af8-bd17-00bd9344e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5564), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5565), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 1, "pilot_mig@bk.ru", false, false },
                    { 3, "a18be9c0-aa65-4af8-bd17-00bd9344e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5568), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5569), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 1, "pilot_mig@bk.ru", false, false },
                    { 4, "a17be9c0-aa65-4af8-bd17-00bd9443e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5714), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5715), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 2, "diman@bk.ru", false, false },
                    { 5, "a17be9c0-aa65-4af8-bd17-00bd9443e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5719), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5720), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 2, "diman@bk.ru", false, false },
                    { 6, "a17be9c0-aa65-4af8-bd17-00bd9443e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5723), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5724), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 2, "diman@bk.ru", false, false },
                    { 7, "a16ce9c0-aa65-4af8-bd17-00bd7213e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5750), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5751), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 3, "sergio@bk.ru", false, false },
                    { 8, "a16ce9c0-aa65-4af8-bd17-00bd7213e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5754), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5755), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 3, "sergio@bk.ru", false, false },
                    { 9, "a16ce9c0-aa65-4af8-bd17-00bd7213e575", new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5758), new DateTime(2021, 9, 10, 21, 55, 6, 990, DateTimeKind.Local).AddTicks(5759), "Vivendum dignissim conceptam pri ut, ei vel partem audiam sapientem. Mandamus abhorreant deseruisse mea at, mea elit deserunt persequeris at, in putant fuisset honestatis qui.", 3, "sergio@bk.ru", false, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ApplicationUserId",
                table: "Messages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_TopicId",
                table: "Messages",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ApplicationUserId",
                table: "Topics",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BanEmails");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
