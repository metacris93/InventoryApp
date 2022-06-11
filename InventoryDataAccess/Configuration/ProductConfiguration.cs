using System;
using InventoryLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryDataAccess.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Jabon Ego",
                    Description = "Aseo personal",
                    TotalQuantity = 15,
                    CategoryId = 2
                },
                new Product()
                {
                    Id = 2,
                    Name = "Olimpia",
                    Description = "Producto de limpieza",
                    TotalQuantity = 20,
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Dolce Gabanna",
                    Description = "Perfume",
                    TotalQuantity = 5,
                    CategoryId = 4
                },
                new Product()
                {
                    Id = 4,
                    Name = "Zelda",
                    Description = "Video juego para Switch",
                    TotalQuantity = 6,
                    CategoryId = 5
                },
                new Product()
                {
                    Id = 5,
                    Name = "Comedor",
                    Description = "Comedor para sala",
                    TotalQuantity = 26,
                    CategoryId = 3
                },
                new Product()
                {
                    Id = 6,
                    Name = "Shampoo Ego",
                    Description = "Caja de shampoo",
                    TotalQuantity = 26,
                    CategoryId = 2
                }
            );
        }
    }
}

