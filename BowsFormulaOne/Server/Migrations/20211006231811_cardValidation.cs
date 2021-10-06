using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BowsFormulaOne.Server.Migrations
{
    public partial class cardValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeNumber",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneNumbers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Emails",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PinCode",
                table: "CardDto",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "CardDto",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate", "PinCode" },
                values: new object[] { new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(7576), new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(7565), new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(7573), "1000" });

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate", "PinCode" },
                values: new object[] { new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(8193), new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(8183), new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(8191), "1200" });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 7, 0, 18, 11, 343, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 7, 0, 18, 11, 340, DateTimeKind.Local).AddTicks(9764), new DateTime(2021, 10, 7, 0, 18, 11, 342, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 7, 0, 18, 11, 342, DateTimeKind.Local).AddTicks(7568), new DateTime(2021, 10, 7, 0, 18, 11, 342, DateTimeKind.Local).AddTicks(7577) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeNumber",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneNumbers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Emails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "PinCode",
                table: "CardDto",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "CardDto",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate", "PinCode" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(9444), new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(9433), new DateTime(2021, 10, 6, 22, 47, 49, 330, DateTimeKind.Local).AddTicks(9442), 1000 });

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate", "PinCode" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 47, 49, 331, DateTimeKind.Local).AddTicks(62), new DateTime(2021, 10, 6, 22, 47, 49, 331, DateTimeKind.Local).AddTicks(52), new DateTime(2021, 10, 6, 22, 47, 49, 331, DateTimeKind.Local).AddTicks(59), 1200 });

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
    }
}
