using System;
using System.Linq.Expressions;
using InventoryBusiness.Contracts;
using InventoryDataAccess;
using Microsoft.EntityFrameworkCore;

namespace InventoryBusiness
{
	public class Repository<T> : IRepository<T> where T : class
	{
        protected readonly InventoryContext _context;

		public Repository(InventoryContext context)
		{
            _context = context;
		}

        public virtual async Task<IEnumerable<T>> All()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public virtual async Task Update(T entity)
        {
            await Task.FromResult(_context.Set<T>().Update(entity));
        }

        public virtual async Task Delete(T entity)
        {
            await Task.FromResult(_context.Set<T>().Remove(entity));
        }

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = ""
        )
        {
            IQueryable<T> query = _context.Set<T>();
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
    }
}

