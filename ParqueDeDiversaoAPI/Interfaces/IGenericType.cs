namespace ParqueDeDiversaoAPI.Interfaces;

public interface IGenericType<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetByID(int id);
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(int id);
}