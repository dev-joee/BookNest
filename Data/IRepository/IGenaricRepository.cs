public interface IGenaricRepository<T> where T : class
{
    Task CreateAsync(T obj);
    void Delete(T obj);
    Task DeleteByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    void Update(T obj);
    Task SaveAsync();
}