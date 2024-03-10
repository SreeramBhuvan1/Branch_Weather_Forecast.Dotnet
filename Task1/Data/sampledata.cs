using System.ComponentModel.DataAnnotations.Schema;

namespace Task1.Data
{
    public class sampledata
    {
        public int Id { get; set; } 
        public string BU_CODES {  get; set; }
        public string STATUS {  get; set; }
        public DateOnly? OPENED_DT { get; set; }
        public string ADDRESS {  get; set; }
        [ForeignKey(nameof(CITYID))]
        public StateTable state { get; set; }
        public int CITYID {  get; set; }
        public string PHONE {  get; set; }
        public string BUSINESS_HOURS {  get; set; }
        public int LATITUDE {  get; set; }
        public int LONGITUDE { get; set;}
    }
}
