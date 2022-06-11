using System;
using InventoryLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryDataAccess.Configuration
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Aseo Hogar",
                    Description = "Productos de aseo del hogar",
                },
                new Category()
                {
                    Id = 2,
                    Name = "Aseo Personal",
                    Description = "Productos de aseo personal",
                },
                new Category()
                {
                    Id = 3,
                    Name = "Hogar",
                    Description = "Realizar actividades del hogar",
                },
                new Category()
                {
                    Id = 4,
                    Name = "Perfumeria",
                    Description = "Perfumeria",
                },
                new Category()
                {
                    Id = 5,
                    Name = "Video Juegos",
                    Description = "Video Juegos",
                }
            );
        }
    }
}

