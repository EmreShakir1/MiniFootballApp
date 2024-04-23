using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;
        
        IQueryable<T> AllReadOnly<T>() where T : class;   

        Task AddAsync<T>(T item) where T : class;

        Task<int> SaveChangesAsync();

        Task DeleteAsync<T>(object id) where T : class;

        Task<T?> GetByIdAsync<T>(object id) where T : class;
    }
}
