using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BowsFormulaOne.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserDtoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CardNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PinCode = table.Column<string>(type: "TEXT", nullable: false),
                    PinAttempts = table.Column<sbyte>(type: "INTEGER", nullable: false),
                    CardLockedTill = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardDto_Users_UserDtoId",
                        column: x => x.UserDtoId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserDtoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Users_UserDtoId",
                        column: x => x.UserDtoId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserDtoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Users_UserDtoId",
                        column: x => x.UserDtoId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "FirstName", "IsDeleted", "LastName", "ModifiedDate" },
                values: new object[] { 1, new DateTime(2021, 10, 7, 10, 35, 45, 725, DateTimeKind.Local).AddTicks(8327), "Es553", "Maxwell", false, "Archer", new DateTime(2021, 10, 7, 10, 35, 45, 727, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "FirstName", "IsDeleted", "LastName", "ModifiedDate" },
                values: new object[] { 2, new DateTime(2021, 10, 7, 10, 35, 45, 727, DateTimeKind.Local).AddTicks(6170), "r7jTG8dqBy5wGO4L", "Alexandra", false, "Archer", new DateTime(2021, 10, 7, 10, 35, 45, 727, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.InsertData(
                table: "CardDto",
                columns: new[] { "Id", "Balance", "CardLockedTill", "CardNumber", "CreatedDate", "ModifiedDate", "PinAttempts", "PinCode", "UserDtoId" },
                values: new object[] { 1, 10m, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(6302), "r7jTG8dqBy5wGO4L", new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(6291), new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(6299), (sbyte)0, "1000", 1 });

            migrationBuilder.InsertData(
                table: "CardDto",
                columns: new[] { "Id", "Balance", "CardLockedTill", "CardNumber", "CreatedDate", "ModifiedDate", "PinAttempts", "PinCode", "UserDtoId" },
                values: new object[] { 2, 20m, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(7132), "r7jTG83qBy5wGO4L", new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(7120), new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(7130), (sbyte)0, "1200", 2 });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 1, "Hex@live.com", false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5037), 1 });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 3, "Hexzero@gmail.com", false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5558), 1 });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 4, "Hex@live.co.uk", false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5566), 1 });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 2, "Alex@gmail.com", false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(5569), 2 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 1, false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(3859), "07667587200", 1 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 3, false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(4387), "07667986200", 1 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 4, false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(4395), "07667987206", 1 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 2, false, new DateTime(2021, 10, 7, 10, 35, 45, 728, DateTimeKind.Local).AddTicks(4398), "07662987201", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_CardDto_UserDtoId",
                table: "CardDto",
                column: "UserDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserDtoId",
                table: "Emails",
                column: "UserDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserDtoId",
                table: "PhoneNumbers",
                column: "UserDtoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardDto");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
