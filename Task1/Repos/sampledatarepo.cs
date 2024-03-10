using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Task1.contracts;
using Task1.Data;

namespace Task1.Repos
{
    public class sampledatarepo : GenericRepository<sampledata>, ISampleDataRepo
    {
        private readonly Task1DbContext context;
        private readonly IMapper mapper;

        public sampledatarepo(Task1DbContext context, IMapper mapper) : base(context, mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<sampledata>> GetDetails(string bu_codes)
        {
           var cityid=await context.SampleData.Include(p=>p.state).Where(p=>p.BU_CODES==bu_codes).ToListAsync();
        
            return cityid;
        }
    }
}
