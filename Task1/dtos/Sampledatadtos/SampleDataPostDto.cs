using System.ComponentModel.DataAnnotations.Schema;
using Task1.Data;

namespace Task1.dtos.Sampledatadtos
{
    public class SampleDataPostDto
    {
       
        public string BU_CODES { get; set; }
        public string STATUS { get; set; }
        public DateOnly OPENED_DT { get; set; }
        public string ADDRESS { get; set; }
        public int CITYID { get; set; }
        public string PHONE { get; set; }
        public string BUSINESS_HOURS { get; set; }
        public int LATITUDE { get; set; }
        public int LONGITUDE { get; set; }
    }
}
