using System;
using InventoryLibrary;

namespace InventoryDataAccess
{
    public class InventorySeeder
    {
        private readonly InventoryContext inventoryDbContext;

        public InventorySeeder(InventoryContext inventoryDbContext)
        {
            this.inventoryDbContext = inventoryDbContext;
        }
        public void Seed()
        {
            inventoryDbContext.Categories.RemoveRange(inventoryDbContext.Categories);
            inventoryDbContext.WareHouses.RemoveRange(inventoryDbContext.WareHouses);
            inventoryDbContext.Products.RemoveRange(inventoryDbContext.Products);
            inventoryDbContext.Storages.RemoveRange(inventoryDbContext.Storages);
            inventoryDbContext.InOuts.RemoveRange(inventoryDbContext.InOuts);

            if (!inventoryDbContext.Categories.Any())
            {
                inventoryDbContext.Categories.AddRange(CreateFakeCategories());
                inventoryDbContext.SaveChanges();
            }
            if (!inventoryDbContext.WareHouses.Any())
            {
                inventoryDbContext.WareHouses.AddRange(CreateFakeWarehouses());
                inventoryDbContext.SaveChanges();
            }
            if (!inventoryDbContext.Products.Any())
            {
                inventoryDbContext.Products.AddRange(CreateFakeProducts());
                inventoryDbContext.SaveChanges();
            }
            if (!inventoryDbContext.Storages.Any())
            {
                inventoryDbContext.Storages.AddRange(CreateFakeStorages());
                inventoryDbContext.SaveChanges();
            }
            if (!inventoryDbContext.InOuts.Any())
            {
                inventoryDbContext.InOuts.AddRange(CreateFakeInouts());
                inventoryDbContext.SaveChanges();
            }
        }
        private IList<Category> CreateFakeCategories() => new List<Category>()
        {
            new Category()
            {
                //Id = 1,
                Name = "Aseo Hogar",
                Description = "Realizar aseo del hogar",
            },
            new Category()
            {
                //Id = 2,
                Name = "Aseo Personal",
                Description = "Realizar aseo personal",
            },
            new Category()
            {
                //Id = 3,
                Name = "Hogar",
                Description = "Realizar actividades del hogar",
            },
            new Category()
            {
                //Id = 4,
                Name = "Perfumeria",
                Description = "Perfumeria",
            },
            new Category()
            {
                //Id = 5,
                Name = "Video Juegos",
                Description = "Video Juegos",
            }
        };
        private IList<Product> CreateFakeProducts() => new List<Product>()
        {
            new Product()
            {
                //Id = 1,
                Name = "Jabon Ego",
                Description = "Aseo personal",
                TotalQuantity = 15,
                CategoryId = 2
            },
            new Product()
            {
                //Id = 2,
                Name = "Olimpia",
                Description = "Producto de limpieza",
                TotalQuantity = 20,
                CategoryId = 1
            },
            new Product()
            {
                //Id = 3,
                Name = "Dolce Gabanna",
                Description = "Perfume",
                TotalQuantity = 5,
                CategoryId = 4
            },
            new Product()
            {
                //Id = 4,
                Name = "Zelda",
                Description = "Video juego para Switch",
                TotalQuantity = 6,
                CategoryId = 5
            }
        };
        private IList<WareHouse> CreateFakeWarehouses() => new List<WareHouse>()
        {
            new WareHouse()
            {
                //Id = 1,
                Name = "Bodega Norte",
                Address = "Norte de la ciudad"
            },
            new WareHouse()
            {
                //Id = 2,
                Name = "Bodega Este",
                Address = "ESte de la ciudad"
            },
            new WareHouse()
            {
                //Id = 3,
                Name = "Bodega Oeste",
                Address = "Oeste de la ciudad"
            },
            new WareHouse()
            {
                //Id = 4,
                Name = "Bodega Sur",
                Address = "Sur de la ciudad"
            }
        };
        private IList<Storage> CreateFakeStorages() => new List<Storage>()
        {
            new Storage()
            {
                //Id = 1,
                LastUpdate = DateTime.Now,
                PartialQuantity = 10,
                ProductId = 1,
                WareHouseId = 1
            },
            new Storage()
            {
                //Id = 2,
                LastUpdate = DateTime.Now,
                PartialQuantity = 15,
                ProductId = 2,
                WareHouseId = 2
            },
            new Storage()
            {
                //Id = 3,
                LastUpdate = DateTime.Now,
                PartialQuantity = 20,
                ProductId = 3,
                WareHouseId = 3
            },
            new Storage()
            {
                //Id = 4,
                LastUpdate = DateTime.Now,
                PartialQuantity = 25,
                ProductId = 4,
                WareHouseId = 4
            }
        };
        private IList<InOut> CreateFakeInouts() => new List<InOut>()
        {
            new InOut()
            {
                //Id = 1,
                EnteredAt = DateTime.Now,
                Quantity = 15,
                IsEntry = true,
                StorageId = 1
            },
            new InOut()
            {
                //Id = 2,
                EnteredAt = DateTime.Now,
                Quantity = 25,
                IsEntry = true,
                StorageId = 2
            },
            new InOut()
            {
                //Id = 3,
                EnteredAt = DateTime.Now,
                Quantity = 15,
                IsEntry = false,
                StorageId = 3
            },
            new InOut()
            {
                //Id = 4,
                EnteredAt = DateTime.Now,
                Quantity = 35,
                IsEntry = false,
                StorageId = 4
            }
        };
    }
}
