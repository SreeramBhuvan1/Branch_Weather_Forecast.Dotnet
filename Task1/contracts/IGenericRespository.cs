namespace Task1.contracts
{
    public interface IGenericRespository< T> where T : class
    {
        Task<T> GetAsync(string bu_codes);
        Task<T> GetAsyncid(int id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string bu_codes);
        Task<bool> Exists(string bu_codes);
        Task<bool> Exists(int id);
    }
}
