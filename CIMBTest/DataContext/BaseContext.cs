using CIMBTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CIMBTest.DataContext
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<UseCase_01> Table_01 { get; set; }
        public DbSet<UseCase_02> Table_02 { get; set; }
        public DbSet<UseCase_03> Table_03 { get; set; }



        protected override void OnModelCreating(ModelBuilder mb)
        {

            base.OnModelCreating(mb);

            mb.Entity<UseCase_01>()
            .HasKey(e => new { e.jeniskredit, e.kreditno });

            mb.Entity<UseCase_01>().HasData(
               new UseCase_01
               {
                   jeniskredit = "X-30",
                   kreditno = 1,
                   Active = "Y",
                   tahunbulan01ht = 0,
                   tahunBulan01 = "202207",
                   tahunBulan01Kol = 1,
                   tahunbulan02ht = 0,
                   tahunBulan02 = "202208",
                   tahunBulan02Kol = 1,
                   tahunbulan03ht = 0,
                   tahunBulan03 = "202209",
                   tahunBulan03Kol = 1,
                   tahunbulan04ht = 0,
                   tahunBulan04 = "202210",
                   tahunBulan04Kol = 1,
                   tahunbulan05ht = 0,
                   tahunBulan05 = "202211",
                   tahunBulan05Kol = 1,
                   tahunbulan06ht = 0,
                   tahunBulan06 = "202212",
                   tahunBulan06Kol = 2,
                   tahunbulan07ht = 31,
                   tahunBulan07 = "202301",
                   tahunBulan07Kol = 2,
                   tahunbulan08ht = 61,
                   tahunBulan08 = "202302",
                   tahunBulan08Kol = 2,
                   tahunbulan09ht = 91,
                   tahunBulan09 = "202303",
                   tahunBulan09Kol = 3,
                   tahunbulan10ht = 0,
                   tahunBulan10 = "202304",
                   tahunBulan10Kol = 1,
                   tahunbulan11ht = 0,
                   tahunBulan11 = "202305",
                   tahunBulan11Kol = 1,
                   tahunbulan12ht = 0,
                   tahunBulan12 = "202306",
                   tahunBulan12Kol = 1,
                   tahunbulan13ht = 0,
                   tahunBulan13 = "202307",
                   tahunBulan13Kol = 1,
                   tahunbulan14ht = 0,
                   tahunBulan14 = "202308",
                   tahunBulan14Kol = 1,
                   tahunbulan15ht = 5,
                   tahunBulan15 = "202309",
                   tahunBulan15Kol = 2,
                   tahunbulan16ht = 35,
                   tahunBulan16 = "202310",
                   tahunBulan16Kol = 2,
                   tahunbulan17ht = 66,
                   tahunBulan17 = "202311",
                   tahunBulan17Kol = 2,
                   tahunbulan18ht = 96,
                   tahunBulan18 = "202312",
                   tahunBulan18Kol = 3,
                   tahunbulan19ht = 127,
                   tahunBulan19 = "202401",
                   tahunBulan19Kol = 4,
                   tahunbulan20ht = 0,
                   tahunBulan20 = "202402",
                   tahunBulan20Kol = 1,
                   tahunbulan21ht = 0,
                   tahunBulan21 = "202403",
                   tahunBulan21Kol = 1,
                   tahunbulan22ht = 0,
                   tahunBulan22 = "202404",
                   tahunBulan22Kol = 1,
                   tahunbulan23ht = 4,
                   tahunBulan23 = "202405",
                   tahunBulan23Kol = 2,
                   tahunbulan24ht = 34,
                   tahunBulan24 = "202406",
                   tahunBulan24Kol = 2
               },
               new UseCase_01()
               {
                   jeniskredit = "X-30",
                   kreditno = 2,
                   Active = "N",
                   tahunbulan01ht = 0,
                   tahunBulan01 = "202207",
                   tahunBulan01Kol = 1,
                   tahunbulan02ht = 30,
                   tahunBulan02 = "202208",
                   tahunBulan02Kol = 2,
                   tahunbulan03ht = 60,
                   tahunBulan03 = "202209",
                   tahunBulan03Kol = 2,
                   tahunbulan04ht = 90,
                   tahunBulan04 = "202210",
                   tahunBulan04Kol = 2,
                   tahunbulan05ht = 120,
                   tahunBulan05 = "202211",
                   tahunBulan05Kol = 3,
                   tahunbulan06ht = 150,
                   tahunBulan06 = "202212",
                   tahunBulan06Kol = 4,
                   tahunbulan07ht = 180,
                   tahunBulan07 = "202301",
                   tahunBulan07Kol = 4,
                   tahunbulan08ht = 210,
                   tahunBulan08 = "202302",
                   tahunBulan08Kol = 5,
                   tahunbulan09ht = 240,
                   tahunBulan09 = "202303",
                   tahunBulan09Kol = 5,
                   tahunbulan10ht = 270,
                   tahunBulan10 = "202304",
                   tahunBulan10Kol = 5,
                   tahunbulan11ht = 300,
                   tahunBulan11 = "202305",
                   tahunBulan11Kol = 5,
                   tahunbulan12ht = 330,
                   tahunBulan12 = "202306",
                   tahunBulan12Kol = 5,
                   tahunbulan13ht = 360,
                   tahunBulan13 = "202307",
                   tahunBulan13Kol = 5,
                   tahunbulan14ht = 390,
                   tahunBulan14 = "202308",
                   tahunBulan14Kol = 5,
                   tahunbulan15ht = 420,
                   tahunBulan15 = "202309",
                   tahunBulan15Kol = 5,
                   tahunbulan16ht = 450,
                   tahunBulan16 = "202310",
                   tahunBulan16Kol = 5,
                   tahunbulan17ht = 480,
                   tahunBulan17 = "202311",
                   tahunBulan17Kol = 2,
                   tahunbulan18ht = 510,
                   tahunBulan18 = "202312",
                   tahunBulan18Kol = 5,
                   tahunbulan19ht = 540,
                   tahunBulan19 = "202401",
                   tahunBulan19Kol = 5,
                   tahunbulan20ht = 570,
                   tahunBulan20 = "202402",
                   tahunBulan20Kol = 5,
                   tahunbulan21ht = 600,
                   tahunBulan21 = "202403",
                   tahunBulan21Kol = 5,
                   tahunbulan22ht = 630,
                   tahunBulan22 = "202404",
                   tahunBulan22Kol = 5,
                   tahunbulan23ht = 660,
                   tahunBulan23 = "202405",
                   tahunBulan23Kol = 5,
                   tahunbulan24ht = 690,
                   tahunBulan24 = "202406",
                   tahunBulan24Kol = 5
               },
               new UseCase_01()
               {
                   jeniskredit = "P05",
                   kreditno = 3,
                   Active = "Y",
                   tahunbulan01ht = 0,
                   tahunBulan01 = "202207",
                   tahunBulan01Kol = 1,
                   tahunbulan02ht = 5,
                   tahunBulan02 = "202208",
                   tahunBulan02Kol = 2,
                   tahunbulan03ht = 35,
                   tahunBulan03 = "202209",
                   tahunBulan03Kol = 2,
                   tahunbulan04ht = 65,
                   tahunBulan04 = "202210",
                   tahunBulan04Kol = 2,
                   tahunbulan05ht = 95,
                   tahunBulan05 = "202211",
                   tahunBulan05Kol = 3,
                   tahunbulan06ht = 0,
                   tahunBulan06 = "202212",
                   tahunBulan06Kol = 1,
                   tahunbulan07ht = 30,
                   tahunBulan07 = "202301",
                   tahunBulan07Kol = 2,
                   tahunbulan08ht = 60,
                   tahunBulan08 = "202302",
                   tahunBulan08Kol = 2,
                   tahunbulan09ht = 90,
                   tahunBulan09 = "202303",
                   tahunBulan09Kol = 2,
                   tahunbulan10ht = 0,
                   tahunBulan10 = "202304",
                   tahunBulan10Kol = 1,
                   tahunbulan11ht = 0,
                   tahunBulan11 = "202305",
                   tahunBulan11Kol = 1,
                   tahunbulan12ht = 0,
                   tahunBulan12 = "202306",
                   tahunBulan12Kol = 1,
                   tahunbulan13ht = 0,
                   tahunBulan13 = "202307",
                   tahunBulan13Kol = 1,
                   tahunbulan14ht = 0,
                   tahunBulan14 = "202308",
                   tahunBulan14Kol = 1,
                   tahunbulan15ht = 0,
                   tahunBulan15 = "202309",
                   tahunBulan15Kol = 1,
                   tahunbulan16ht = 0,
                   tahunBulan16 = "202310",
                   tahunBulan16Kol = 1,
                   tahunbulan17ht = 0,
                   tahunBulan17 = "202311",
                   tahunBulan17Kol = 1,
                   tahunbulan18ht = 37,
                   tahunBulan18 = "202312",
                   tahunBulan18Kol = 2,
                   tahunbulan19ht = 31,
                   tahunBulan19 = "202401",
                   tahunBulan19Kol = 2,
                   tahunbulan20ht = 67,
                   tahunBulan20 = "202402",
                   tahunBulan20Kol = 2,
                   tahunbulan21ht = 97,
                   tahunBulan21 = "202403",
                   tahunBulan21Kol = 3,
                   tahunbulan22ht = 0,
                   tahunBulan22 = "202404",
                   tahunBulan22Kol = 1,
                   tahunbulan23ht = 1,
                   tahunBulan23 = "202405",
                   tahunBulan23Kol = 2,
                   tahunbulan24ht = 31,
                   tahunBulan24 = "202406",
                   tahunBulan24Kol = 2
               }
           );

            mb.Entity<UseCase_02>().HasData(
                new UseCase_02
                {
                    Id = 1,
                    CIF = 999999,
                    MonthlyIncome = 23000000,
                    FacilityType = "Credit Card",
                    Plafond = 10000000,
                    Outstanding = 8000000,
                    DueDate = null, // Sesuaikan dengan data yang sebenarnya
                    FacilityStartDate = null, // Sesuaikan dengan data yang sebenarnya
                    PercentageOfAnnualInterestRate = (decimal)30.2,
                    UsageType = "Consumption",
                    Status = "Yes",
                    Tenor = null, // Sesuaikan dengan data yang sebenarnya
                    Installment = 800000
                },
                new UseCase_02
                {
                    Id = 2,
                    CIF = 999999,
                    MonthlyIncome = 23000000,
                    FacilityType = "Credit Card",
                    Plafond = 5000000,
                    Outstanding = 750000,
                    DueDate = null, // Sesuaikan dengan data yang sebenarnya
                    FacilityStartDate = null, // Sesuaikan dengan data yang sebenarnya
                    PercentageOfAnnualInterestRate = (decimal)30.2,
                    UsageType = "Consumption",
                    Status = "Yes",
                    Tenor = null, // Sesuaikan dengan data yang sebenarnya
                    Installment = 75000
                },
                new UseCase_02
                {
                    Id = 3,
                    CIF = 999999,
                    MonthlyIncome = 23000000,
                    FacilityType = "Personal Loan",
                    Plafond = 15000000,
                    Outstanding = 13000000,
                    DueDate = 45918,
                    FacilityStartDate = 44457,
                    PercentageOfAnnualInterestRate = (decimal)17.8,
                    UsageType = "Consumption",
                    Status = "Yes",
                    Tenor = 48,
                    Installment = (decimal)439058.91
                },
                new UseCase_02
                {
                    Id = 4,
                    CIF = 999999,
                    MonthlyIncome = 23000000,
                    FacilityType = "Mortgage",
                    Plafond = 780000000,
                    Outstanding = 615000000,
                    DueDate = 47765,
                    FacilityStartDate = 42265,
                    PercentageOfAnnualInterestRate = (decimal)7.8,
                    UsageType = "Consumption",
                    Status = "Yes",
                    Tenor = 180,
                    Installment = (decimal)7364307.72
                }
            );
            mb.Entity<UseCase_03>().HasData(
                new UseCase_03
                {
                    Id = 1,
                    CIF = 8888888,
                    MonthlyIncome = 23000000,
                    Age = 45,
                    Gender = "Male",
                    Occupation = "Employee"
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

    }
}
