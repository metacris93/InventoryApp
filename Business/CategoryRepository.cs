using System;
using InventoryBusiness.Contracts;
using InventoryDataAccess;
using InventoryLibrary;

namespace InventoryBusiness
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(InventoryContext context) : base(context)
        {
        }
    }
}

