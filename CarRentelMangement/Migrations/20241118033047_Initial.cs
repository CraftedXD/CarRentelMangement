using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentelMangement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(998), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1170), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1264), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1268), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1270), new DateTime(2024, 11, 18, 11, 30, 47, 225, DateTimeKind.Local).AddTicks(1270) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 11, 18, 11, 29, 33, 473, DateTimeKind.Local).AddTicks(5562) });
        }
    }
}
