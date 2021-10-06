using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BowsFormulaOne.Server.Migrations
{
    public partial class modifyCardDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(9444), new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(9433), new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 47, 49, 331, DateTimeKind.Local).AddTicks(62), new DateTime(2021, 10, 6, 22, 47, 49, 331, DateTimeKind.Local).AddTicks(52), new DateTime(2021, 10, 6, 22, 47, 49, 331, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 47, 49, 328, DateTimeKind.Local).AddTicks(1971), new DateTime(2021, 10, 6, 22, 47, 49, 329, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 47, 49, 329, DateTimeKind.Local).AddTicks(9463), new DateTime(2021, 10, 6, 22, 47, 49, 329, DateTimeKind.Local).AddTicks(9472) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3097), new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3085), new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3702), new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3692), new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 6, 19, 29, 6, 898, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 19, 29, 6, 895, DateTimeKind.Local).AddTicks(5141), new DateTime(2021, 10, 6, 19, 29, 6, 897, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 19, 29, 6, 897, DateTimeKind.Local).AddTicks(3174), new DateTime(2021, 10, 6, 19, 29, 6, 897, DateTimeKind.Local).AddTicks(3184) });
        }
    }
}
