using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Core.Models;
using WebAPIQuiz.Core.Repositories;
using WebAPIQuiz.Data.Contexts;

namespace WebAPIQuiz.Data.Repo.Implementation;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly WebAPIQuizDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(WebAPIQuizDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<T>();
    }
    public async Task<T> AddAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<int> CommitAsync()
    {
       return await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        _dbSet.Remove(entity);
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _dbSet.AsQueryable();
        if(includes != null)
        {
            foreach(var include in includes)
                query = query.Include(include);
        }
        if(filter != null) 
            query = query.Where(filter);

        if(orderBy != null)
            query = orderBy(query);

        return await query.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes)
    {
        if (includes == null) throw new ArgumentNullException(nameof(includes));
        IQueryable<T> query = _dbSet;
        query = includes.Aggregate(query, (current, include) => current.Include(include));
        var entity = await query.FirstOrDefaultAsync(e => EF.Property<int>(e,"id") == id);
        return entity ?? throw new KeyNotFoundException("Id not found");
    }

    public async Task UpdateAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        _dbSet.Update(entity);
    }
}
