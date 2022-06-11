using System;
using InventoryBusiness.Contracts;
using InventoryDataAccess;
using InventoryLibrary;

namespace InventoryBusiness
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(InventoryContext context) : base(context)
		{
		}
	}
}

