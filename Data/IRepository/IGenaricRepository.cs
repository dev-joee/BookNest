namespace BookNest.Data.IRepository;

public interface IGenaricRepository<T> where T : class
{
    void Create(T obj);
    void Update(T obj);
    void Delete(T obj);
    void DeleteById(int id);
    IEnumerable<T>? GetAll();
    T? GetById(int id);
    void Save();
}
