using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Task1.contracts;
using Task1.Data;

namespace Task1.Repos
{
    public class GenericRepository<T> : IGenericRespository<T> where T : class
    {
        private readonly Task1DbContext _context;
        private readonly IMapper _mapper;
        public GenericRepository(Task1DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(string bu_codes)
        {
            var e = await GetAsync(bu_codes);
            _context.Set<T>().Remove(e);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(string bu_codes)
        {
            var e = await GetAsync(bu_codes);
            return e != null;
        }
        public async Task<bool> Exists(int id)
        {
            var e = await GetAsyncid(id);
            return e != null;
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(string? bu_codes)
        {
            if (bu_codes == null)
            {
                return null;
            }
            var i = await _context.SampleData.Where(p=>p.BU_CODES==bu_codes).Select(x => x.Id).ToListAsync();
            int a = i[0];
            return await _context.Set<T>().FindAsync(a);
        }
        public async Task<T> GetAsyncid(int id)
        {
            if (id == null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
