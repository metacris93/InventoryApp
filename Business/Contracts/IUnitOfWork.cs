using System;
namespace InventoryBusiness.Contracts
{
	public interface IUnitOfWork : IDisposable
	{
		public ICategoryRepository Categories { get; }
		public IProductRepository Products { get; }
		public IInoutRepository Inouts { get; }
		public IStorageRepository Storages { get; }
		public IWarehouseRepository Warehouses { get; }
		Task<int> CompleteAsync();
	}
}

