using System;
using InventoryLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryDataAccess.Configuration
{
    public class InOutConfiguration : IEntityTypeConfiguration<InOut>
    {
        public void Configure(EntityTypeBuilder<InOut> builder)
        {
            builder.HasData(
                new InOut()
                {
                    Id = 1,
                    EnteredAt = DateTime.Now,
                    Quantity = 15,
                    IsEntry = true,
                    StorageId = 1
                },
                new InOut()
                {
                    Id = 2,
                    EnteredAt = DateTime.Now,
                    Quantity = 25,
                    IsEntry = true,
                    StorageId = 2
                },
                new InOut()
                {
                    Id = 3,
                    EnteredAt = DateTime.Now,
                    Quantity = 15,
                    IsEntry = false,
                    StorageId = 3
                },
                new InOut()
                {
                    Id = 4,
                    EnteredAt = DateTime.Now,
                    Quantity = 35,
                    IsEntry = false,
                    StorageId = 4
                }
            );
        }
    }
}

