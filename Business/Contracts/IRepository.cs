using System;
using System.Linq.Expressions;

namespace InventoryBusiness.Contracts
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> All();
		Task<T> GetById(object id);
		Task Create(T entity);
		Task Update(T entity);
		Task Delete(T entity);
		IEnumerable<T> Get(
			Expression<Func<T,bool>>? filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
			string includeProperties = ""
		);
	}
}

