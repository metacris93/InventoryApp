using System;
using InventoryLibrary;

namespace InventoryBusiness.Contracts
{
	public interface IStorageRepository : IRepository<Storage>
	{
		bool IsProductInStorage(int productId, int warehouseId);
		IEnumerable<Storage> GetStorageByWarehouse(int warehouseId);
	}
}

