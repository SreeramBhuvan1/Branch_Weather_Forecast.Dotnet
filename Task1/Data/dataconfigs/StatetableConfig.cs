using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1.Data.dataconfigs
{
    public class StatetableConfig : IEntityTypeConfiguration<StateTable>
    {
        public void Configure(EntityTypeBuilder<StateTable> builder)
        {
            builder.HasData(
                new StateTable
                {
                    ID = 100,
                    CITY = "EDMONTON",
                    STATE_NAME = "Alberta",
                    COUNTRY_NAME = "Canada",
                    CURRENCY = "CAD",
                },
new StateTable
{
    ID = 101,

    CITY = "ACHESON",
    STATE_NAME = "Alberta",
    COUNTRY_NAME = "Canada",
    CURRENCY = "CAD",
},
new StateTable
{
    ID = 102,

    CITY = "AIRDRIE",
    STATE_NAME = "Alberta",
    COUNTRY_NAME = "Canada",
    CURRENCY = "CAD",
},
new StateTable
{
    ID = 103,

    CITY = "CALGARY",
    STATE_NAME = "Alberta",
    COUNTRY_NAME = "Canada",
    CURRENCY = "CAD",
},
  new StateTable
  {
      ID = 104,

      CITY = "GRANDE PRAIRIE",
      STATE_NAME = "Alberta",
      COUNTRY_NAME = "Canada",
      CURRENCY = "CAD",
  },
    new StateTable
    {
        ID = 105,

        CITY = "NISKU",
        STATE_NAME = "Alberta",
        COUNTRY_NAME = "Canada",
        CURRENCY = "CAD",
    },
     new StateTable
     {
         ID = 106,

         CITY = "LLOYDMINSTER",
         STATE_NAME = "Alberta",
         COUNTRY_NAME = "Canada",
         CURRENCY = "CAD",
     },
     new StateTable
     {
         ID = 107,

         CITY = "MEDICINE HAT",
         STATE_NAME = "Alberta",
         COUNTRY_NAME = "Canada",
         CURRENCY = "CAD",
     },
     new StateTable
     {
         ID = 108,

         CITY = "RED DEER",
         STATE_NAME = "Alberta",
         COUNTRY_NAME = "Canada",
         CURRENCY = "CAD",
     },
      new StateTable
      {
          ID = 109,

          CITY = "WHITECOURT",
          STATE_NAME = "Alberta",
          COUNTRY_NAME = "Canada",
          CURRENCY = "CAD",
      },
       new StateTable
       {
           ID = 110,

           CITY = "ANCHORAGE",
           STATE_NAME = "Alaska",
           COUNTRY_NAME = "United States",
           CURRENCY = "USD",
       },
       new StateTable
       {
           ID = 111,
           CITY = "FAIRBANKS",
           STATE_NAME = "Alaska",
           COUNTRY_NAME = "United States",
           CURRENCY = "USD",
       });
        }
    }
}
