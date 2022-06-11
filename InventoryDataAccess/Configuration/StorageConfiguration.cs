using System;
using InventoryLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryDataAccess.Configuration
{
    public class StorageConfiguration : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder.HasData(
                new Storage()
                {
                    Id = 1,
                    LastUpdate = DateTime.Now,
                    PartialQuantity = 10,
                    ProductId = 1,
                    WareHouseId = 1
                },
                new Storage()
                {
                    Id = 2,
                    LastUpdate = DateTime.Now,
                    PartialQuantity = 15,
                    ProductId = 2,
                    WareHouseId = 2
                },
                new Storage()
                {
                    Id = 3,
                    LastUpdate = DateTime.Now,
                    PartialQuantity = 20,
                    ProductId = 3,
                    WareHouseId = 3
                },
                new Storage()
                {
                    Id = 4,
                    LastUpdate = DateTime.Now,
                    PartialQuantity = 25,
                    ProductId = 4,
                    WareHouseId = 4
                }
            );
        }
    }
}

