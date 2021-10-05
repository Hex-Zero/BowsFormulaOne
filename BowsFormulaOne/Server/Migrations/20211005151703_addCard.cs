using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BowsFormulaOne.Server.Migrations
{
    public partial class addCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserDtoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CardNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PinCode = table.Column<int>(type: "INTEGER", nullable: false),
                    PinAttempts = table.Column<sbyte>(type: "INTEGER", nullable: false),
                    CardLockedTill = table.Column<DateTime>(type: "TEXT", nullable: false)
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

            migrationBuilder.InsertData(
                table: "CardDto",
                columns: new[] { "Id", "CardLockedTill", "CardNumber", "CreatedDate", "ModifiedDate", "PinAttempts", "PinCode", "UserDtoId" },
                values: new object[] { 1, new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(5592), "r7jTG8dqBy5wGO4L", new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(5580), new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(5589), (sbyte)0, 1000, 1 });

            migrationBuilder.InsertData(
                table: "CardDto",
                columns: new[] { "Id", "CardLockedTill", "CardNumber", "CreatedDate", "ModifiedDate", "PinAttempts", "PinCode", "UserDtoId" },
                values: new object[] { 2, new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(6207), "r7jTG83qBy5wGO4L", new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(6197), new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(6205), (sbyte)0, 1200, 2 });

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmailAddress", "ModifiedDate" },
                values: new object[] { "Hex@live.com", new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EmailAddress", "ModifiedDate" },
                values: new object[] { "Hexzero@gmail.com", new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EmailAddress", "ModifiedDate" },
                values: new object[] { "Hex@live.co.uk", new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3305), "07667587200" });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3852), "07662987201" });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3840), "07667986200" });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3849), "07667987206" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeNumber", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 628, DateTimeKind.Local).AddTicks(3535), "Es553", new DateTime(2021, 10, 5, 16, 17, 2, 630, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 630, DateTimeKind.Local).AddTicks(5286), new DateTime(2021, 10, 5, 16, 17, 2, 630, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.CreateIndex(
                name: "IX_CardDto_UserDtoId",
                table: "CardDto",
                column: "UserDtoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardDto");

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmailAddress", "ModifiedDate" },
                values: new object[] { "Hex0@live.com", new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EmailAddress", "ModifiedDate" },
                values: new object[] { "Hexzerolove@gmail.com", new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EmailAddress", "ModifiedDate" },
                values: new object[] { "Hex0@live.co.uk", new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(270), "07767987200" });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(821), "07767987201" });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(809), "07767986200" });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModifiedDate", "PhoneNumber" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(818), "07767987206" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmployeeNumber", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 210, DateTimeKind.Local).AddTicks(4813), "r7jTG7dqBy5wGO4L", new DateTime(2021, 10, 5, 12, 12, 22, 212, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 212, DateTimeKind.Local).AddTicks(2695), new DateTime(2021, 10, 5, 12, 12, 22, 212, DateTimeKind.Local).AddTicks(2704) });
        }
    }
}
