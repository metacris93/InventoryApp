using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryDataAccess.Migrations
{
    public partial class AdditionalRowsInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Productos de aseo del hogar");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Productos de aseo personal");

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 3,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 4,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "TotalQuantity" },
                values: new object[,]
                {
                    { 5, 3, "Comedor para sala", "Comedor", 26 },
                    { 6, 2, "Caja de shampoo", "Shampoo Ego", 26 }
                });

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 18, 47, 8, 791, DateTimeKind.Local).AddTicks(3370));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Realizar aseo del hogar");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Realizar aseo personal");

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 3,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "InOut",
                keyColumn: "Id",
                keyValue: 4,
                column: "EnteredAt",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Storage",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdate",
                value: new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6960));
        }
    }
}
