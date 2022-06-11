using System;
using InventoryBusiness.Contracts;
using InventoryDataAccess;
using InventoryLibrary;

namespace InventoryBusiness
{
	public class InoutRepository : Repository<InOut>, IInoutRepository
	{
		public InoutRepository(InventoryContext context) : base(context)
		{
		}
	}
}

