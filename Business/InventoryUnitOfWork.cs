using System;
using InventoryBusiness.Contracts;
using InventoryDataAccess;

namespace InventoryBusiness
{
	public class InventoryUnitOfWork : IUnitOfWork
	{
		private readonly InventoryContext _context;

        public ICategoryRepository Categories { get; private set; }

        public IProductRepository Products { get; private set; }

        public IInoutRepository Inouts { get; private set; }

        public IStorageRepository Storages { get; private set; }

        public IWarehouseRepository Warehouses { get; private set; }

        public InventoryUnitOfWork(InventoryContext context,
            ICategoryRepository category,
            IProductRepository product,
            IInoutRepository inout,
            IStorageRepository storage,
            IWarehouseRepository warehouse)
		{
			_context = context;
			Categories = category;
            Products = product;
            Inouts = inout;
            Storages = storage;
            Warehouses = warehouse;
		}

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

