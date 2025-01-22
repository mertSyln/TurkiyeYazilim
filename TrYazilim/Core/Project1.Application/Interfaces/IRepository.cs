using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAllAsync();
        Task AddAsync(T entity);
                
    }
}
