using System;
using InventoryBusiness.Contracts;
using InventoryDataAccess;
using InventoryLibrary;

namespace InventoryBusiness
{
	public class WarehouseRepository : Repository<WareHouse>, IWarehouseRepository
	{
		public WarehouseRepository(InventoryContext context) : base(context)
		{
		}
	}
}

