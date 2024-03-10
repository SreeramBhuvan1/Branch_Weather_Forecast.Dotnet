using Microsoft.EntityFrameworkCore;

namespace Task1.Data
{
    public class StateTable
    {
        public int ID {  get; set; }
        public string CITY {  get; set; }
        public string STATE_NAME {  get; set; }
        public string COUNTRY_NAME {  get; set; }
        public string CURRENCY {  get; set; }
        public virtual IList<sampledata> sampledata { get; set; }
    }
}
