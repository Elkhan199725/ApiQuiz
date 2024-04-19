using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Core.Models;

namespace WebAPIQuiz.Core.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes);
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
        params Expression<Func<T, object>>[] includes);

    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<int> CommitAsync();
}
