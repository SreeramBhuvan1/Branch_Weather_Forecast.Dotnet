using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Mono.TextTemplating;
using Task1.Data.dataconfigs;

namespace Task1.Data
{
    public class Task1DbContext:IdentityDbContext<ApiUser>
    {
        public Task1DbContext(DbContextOptions options) : base(options)
        {

        }
        public Task1DbContext()
        {
            
        }
        public DbSet<sampledata> SampleData { get; set; }
        public DbSet<StateTable>stateTables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Task1Db; Trusted_Connection=True;  MultipleActiveResultsets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StatetableConfig());
            modelBuilder.ApplyConfiguration(new roles());
            modelBuilder.Entity<sampledata>().HasData(

              
                new sampledata
                {
                    Id = 1,
                    BU_CODES = "AB100",
                    STATUS="Open",
                    OPENED_DT=new DateOnly(2008,9,15),
                    ADDRESS= "19020   111th Ave",
                    CITYID= 100,
                    PHONE= "780-801-5006",
                    BUSINESS_HOURS= "Monday - Friday 7:30am - 5:00pm",
                    LATITUDE=54,
                    LONGITUDE=-114
                }
                );
           // modelBuilder.Entity<StateTable>());

        }
    }
}
