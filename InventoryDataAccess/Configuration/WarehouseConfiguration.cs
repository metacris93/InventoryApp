using System;
using InventoryLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryDataAccess.Configuration
{
	public class WarehouseConfiguration : IEntityTypeConfiguration<WareHouse>
	{
        public void Configure(EntityTypeBuilder<WareHouse> builder)
        {
            builder.HasData(
                new WareHouse()
                {
                    Id = 1,
                    Name = "Bodega Norte",
                    Address = "Norte de la ciudad"
                },
                new WareHouse()
                {
                    Id = 2,
                    Name = "Bodega Este",
                    Address = "ESte de la ciudad"
                },
                new WareHouse()
                {
                    Id = 3,
                    Name = "Bodega Oeste",
                    Address = "Oeste de la ciudad"
                },
                new WareHouse()
                {
                    Id = 4,
                    Name = "Bodega Sur",
                    Address = "Sur de la ciudad"
                }
            );
        }
    }
}

