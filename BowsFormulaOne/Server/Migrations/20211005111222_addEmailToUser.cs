using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BowsFormulaOne.Server.Migrations
{
    public partial class addEmailToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserDtoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailDto_Users_UserDtoId",
                        column: x => x.UserDtoId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmailDto",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 1, "Hex0@live.com", false, new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1375), 1 });

            migrationBuilder.InsertData(
                table: "EmailDto",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 3, "Hexzerolove@gmail.com", false, new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1841), 1 });

            migrationBuilder.InsertData(
                table: "EmailDto",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 4, "Hex0@live.co.uk", false, new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1849), 1 });

            migrationBuilder.InsertData(
                table: "EmailDto",
                columns: new[] { "Id", "EmailAddress", "IsDeleted", "ModifiedDate", "UserDtoId" },
                values: new object[] { 2, "Alex@gmail.com", false, new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(1851), 2 });

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 12, 12, 22, 213, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 210, DateTimeKind.Local).AddTicks(4813), new DateTime(2021, 10, 5, 12, 12, 22, 212, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 12, 12, 22, 212, DateTimeKind.Local).AddTicks(2695), new DateTime(2021, 10, 5, 12, 12, 22, 212, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.CreateIndex(
                name: "IX_EmailDto_UserDtoId",
                table: "EmailDto",
                column: "UserDtoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailDto");

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 10, 45, 24, 622, DateTimeKind.Local).AddTicks(7558), new DateTime(2021, 10, 5, 10, 45, 24, 624, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 10, 45, 24, 624, DateTimeKind.Local).AddTicks(4970), new DateTime(2021, 10, 5, 10, 45, 24, 624, DateTimeKind.Local).AddTicks(4980) });
        }
    }
}
