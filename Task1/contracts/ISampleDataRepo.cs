using Task1.Data;

namespace Task1.contracts
{
    public interface ISampleDataRepo:IGenericRespository<sampledata>
    {
        Task<List<sampledata>> GetDetails(string bu_codes);
    }
}
