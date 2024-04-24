using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext dbContext;

        public Repository(MiniFootballDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return dbContext.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking().AsQueryable();
        }

        public async Task AddAsync<T>(T item) where T : class
        {
            await DbSet<T>().AddAsync(item);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(object id) where T : class
        {
            var entity = await GetByIdAsync<T>(id);

            if (entity != null)
            {
                DbSet<T>().Remove(entity);
            }
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }
    }
}
