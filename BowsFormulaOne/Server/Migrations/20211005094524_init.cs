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
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserDtoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
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
                values: new object[] { 1, new DateTime(2021, 10, 5, 10, 45, 24, 622, DateTimeKind.Local).AddTicks(7558), "r7jTG7dqBy5wGO4L", "Maxwell", false, "Archer", new DateTime(2021, 10, 5, 10, 45, 24, 624, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "EmployeeNumber", "FirstName", "IsDeleted", "LastName", "ModifiedDate" },
                values: new object[] { 2, new DateTime(2021, 10, 5, 10, 45, 24, 624, DateTimeKind.Local).AddTicks(4970), "r7jTG8dqBy5wGO4L", "Alexandra", false, "Archer", new DateTime(2021, 10, 5, 10, 45, 24, 624, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 1, false, new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(2420), "07767987200", 1 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 3, false, new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(2996), "07767986200", 1 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 4, false, new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(3005), "07767987206", 1 });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "IsDeleted", "ModifiedDate", "PhoneNumber", "UserDtoId" },
                values: new object[] { 2, false, new DateTime(2021, 10, 5, 10, 45, 24, 625, DateTimeKind.Local).AddTicks(3008), "07767987201", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserDtoId",
                table: "PhoneNumbers",
                column: "UserDtoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
