using System;
using System.Linq;
using Bitpocket.ScreenTimer.Data;
using Bitpocket.ScreenTimer.Data.Repository;
using System.Linq.Expressions;

namespace Bitpocket.ScreenTimer.Test
{
	public class ScreenTimerRepository : IRepository
	{
		private screentimer_dbEntitiesContext _context;

		public ScreenTimerRepository()
		{
			_context = new screentimer_dbEntitiesContext();
		}

		public IQueryable<T> All<T>() where T : class
		{
			return _context.Set<T>();
		}

		public void Dispose()
		{
			if (_context != null) _context.Dispose();
		}

		public IQueryable<T> AllIncluding<T>(params Expression<Func<T, object>>[] include) where T : class
		{
			IQueryable<T> result = _context.Set<T>();

			return result;
		}

		public IQueryable<T> GetUser<T>(string name) where T : class
		{
			IQueryable<T> result = _context.Set<T>();
			return result;
		}
	}
}