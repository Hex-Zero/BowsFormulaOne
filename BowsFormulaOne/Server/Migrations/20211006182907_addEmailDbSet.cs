using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BowsFormulaOne.Server.Migrations
{
    public partial class addEmailDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailDto_Users_UserDtoId",
                table: "EmailDto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailDto",
                table: "EmailDto");

            migrationBuilder.RenameTable(
                name: "EmailDto",
                newName: "Emails");

            migrationBuilder.RenameIndex(
                name: "IX_EmailDto_UserDtoId",
                table: "Emails",
                newName: "IX_Emails_UserDtoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Users_UserDtoId",
                table: "Emails",
                column: "UserDtoId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Users_UserDtoId",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "EmailDto");

            migrationBuilder.RenameIndex(
                name: "IX_Emails_UserDtoId",
                table: "EmailDto",
                newName: "IX_EmailDto_UserDtoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailDto",
                table: "EmailDto",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(5592), new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(5580), new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "CardDto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardLockedTill", "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(6207), new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(6197), new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(4424));

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
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "EmailDto",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "PhoneNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedDate",
                value: new DateTime(2021, 10, 5, 16, 17, 2, 631, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 628, DateTimeKind.Local).AddTicks(3535), new DateTime(2021, 10, 5, 16, 17, 2, 630, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 10, 5, 16, 17, 2, 630, DateTimeKind.Local).AddTicks(5286), new DateTime(2021, 10, 5, 16, 17, 2, 630, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.AddForeignKey(
                name: "FK_EmailDto_Users_UserDtoId",
                table: "EmailDto",
                column: "UserDtoId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
