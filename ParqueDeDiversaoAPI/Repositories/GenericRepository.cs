using Microsoft.EntityFrameworkCore;
using ParqueDeDiversaoAPI.ApplicationDbContext;
using ParqueDeDiversaoAPI.Interfaces;

namespace ParqueDeDiversaoAPI.Repositories;

public class GenericRepository<T> : IGenericType<T> where T : class
{
    private readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
    }


    public virtual async Task<T> Add(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity; 
    }

    public virtual async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public Task<T> GetByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> Update(T entity)
    {
        throw new NotImplementedException();
    }
    
    public Task<T> Delete(int id)
    {
        throw new NotImplementedException();
    }
}