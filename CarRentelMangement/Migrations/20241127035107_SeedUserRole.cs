using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentelMangement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4827), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 11, 27, 11, 51, 6, 976, DateTimeKind.Local).AddTicks(4832) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(206), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(355), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(420), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(421), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(422), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(424), new DateTime(2024, 11, 27, 11, 39, 10, 418, DateTimeKind.Local).AddTicks(424) });
        }
    }
}
