using System;
using InventoryBusiness.Contracts;
using InventoryDataAccess;
using InventoryLibrary;
using Microsoft.EntityFrameworkCore;

namespace InventoryBusiness
{
	public class StorageRepository : Repository<Storage>, IStorageRepository
	{
		public StorageRepository(InventoryContext context) : base(context)
		{
		}
		public bool IsProductInStorage(int productId, int warehouseId)
		{
			return Get(filter: s => s.ProductId == productId && s.WareHouseId == warehouseId).Any();
		}
		public IEnumerable<Storage> GetStorageByWarehouse(int warehouseId)
        {
			return _context.Storages
				.Include(s => s.Product)
				.Include(s => s.WareHouse)
				.Where(s => s.WareHouseId == warehouseId)
				.ToList();
        }
	}
}

