using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryDataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartialQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WareHouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Storage_WareHouse_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "WareHouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InOut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsEntry = table.Column<bool>(type: "bit", nullable: false),
                    StorageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InOut_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Realizar aseo del hogar", "Aseo Hogar" },
                    { 2, "Realizar aseo personal", "Aseo Personal" },
                    { 3, "Realizar actividades del hogar", "Hogar" },
                    { 4, "Perfumeria", "Perfumeria" },
                    { 5, "Video Juegos", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "WareHouse",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Norte de la ciudad", "Bodega Norte" },
                    { 2, "ESte de la ciudad", "Bodega Este" },
                    { 3, "Oeste de la ciudad", "Bodega Oeste" },
                    { 4, "Sur de la ciudad", "Bodega Sur" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "TotalQuantity" },
                values: new object[,]
                {
                    { 1, 2, "Aseo personal", "Jabon Ego", 15 },
                    { 2, 1, "Producto de limpieza", "Olimpia", 20 },
                    { 3, 4, "Perfume", "Dolce Gabanna", 5 },
                    { 4, 5, "Video juego para Switch", "Zelda", 6 }
                });

            migrationBuilder.InsertData(
                table: "Storage",
                columns: new[] { "Id", "LastUpdate", "PartialQuantity", "ProductId", "WareHouseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6930), 10, 1, 1 },
                    { 2, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6960), 15, 2, 2 },
                    { 3, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6960), 20, 3, 3 },
                    { 4, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6960), 25, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "InOut",
                columns: new[] { "Id", "EnteredAt", "IsEntry", "Quantity", "StorageId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6970), true, 15, 1 },
                    { 2, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6980), true, 25, 2 },
                    { 3, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6980), false, 15, 3 },
                    { 4, new DateTime(2022, 6, 9, 17, 8, 7, 726, DateTimeKind.Local).AddTicks(6980), false, 35, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InOut_StorageId",
                table: "InOut",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_ProductId",
                table: "Storage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_WareHouseId",
                table: "Storage",
                column: "WareHouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InOut");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "WareHouse");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
