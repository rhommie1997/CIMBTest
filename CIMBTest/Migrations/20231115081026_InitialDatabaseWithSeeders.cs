using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIMBTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabaseWithSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_01",
                columns: table => new
                {
                    jeniskredit = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    kreditno = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunbulan01ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan01Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan02ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan02Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan03ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan03Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan04ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan04Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan05ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan05Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan06ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan06Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan07ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan07Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan08ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan08Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan09ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan09Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan10ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan10Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan11ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan11Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan12ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan12Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan13ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan13Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan14ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan14Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan15ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan15Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan16ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan16Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan17ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan17Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan18ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan18Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan19ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan19Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan20ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan20Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan21ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan21Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan22ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan22Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan23ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan23Kol = table.Column<int>(type: "int", nullable: false),
                    tahunbulan24ht = table.Column<int>(type: "int", nullable: false),
                    tahunBulan24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tahunBulan24Kol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_01", x => new { x.jeniskredit, x.kreditno });
                });

            migrationBuilder.CreateTable(
                name: "Table_02",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIF = table.Column<int>(type: "int", nullable: false),
                    MonthlyIncome = table.Column<int>(type: "int", nullable: false),
                    FacilityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plafond = table.Column<int>(type: "int", nullable: false),
                    Outstanding = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<int>(type: "int", nullable: true),
                    FacilityStartDate = table.Column<int>(type: "int", nullable: true),
                    PercentageOfAnnualInterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tenor = table.Column<int>(type: "int", nullable: true),
                    Installment = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_02", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table_03",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIF = table.Column<int>(type: "int", nullable: false),
                    MonthlyIncome = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_03", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Table_01",
                columns: new[] { "jeniskredit", "kreditno", "Active", "tahunBulan01", "tahunBulan01Kol", "tahunBulan02", "tahunBulan02Kol", "tahunBulan03", "tahunBulan03Kol", "tahunBulan04", "tahunBulan04Kol", "tahunBulan05", "tahunBulan05Kol", "tahunBulan06", "tahunBulan06Kol", "tahunBulan07", "tahunBulan07Kol", "tahunBulan08", "tahunBulan08Kol", "tahunBulan09", "tahunBulan09Kol", "tahunBulan10", "tahunBulan10Kol", "tahunBulan11", "tahunBulan11Kol", "tahunBulan12", "tahunBulan12Kol", "tahunBulan13", "tahunBulan13Kol", "tahunBulan14", "tahunBulan14Kol", "tahunBulan15", "tahunBulan15Kol", "tahunBulan16", "tahunBulan16Kol", "tahunBulan17", "tahunBulan17Kol", "tahunBulan18", "tahunBulan18Kol", "tahunBulan19", "tahunBulan19Kol", "tahunBulan20", "tahunBulan20Kol", "tahunBulan21", "tahunBulan21Kol", "tahunBulan22", "tahunBulan22Kol", "tahunBulan23", "tahunBulan23Kol", "tahunBulan24", "tahunBulan24Kol", "tahunbulan01ht", "tahunbulan02ht", "tahunbulan03ht", "tahunbulan04ht", "tahunbulan05ht", "tahunbulan06ht", "tahunbulan07ht", "tahunbulan08ht", "tahunbulan09ht", "tahunbulan10ht", "tahunbulan11ht", "tahunbulan12ht", "tahunbulan13ht", "tahunbulan14ht", "tahunbulan15ht", "tahunbulan16ht", "tahunbulan17ht", "tahunbulan18ht", "tahunbulan19ht", "tahunbulan20ht", "tahunbulan21ht", "tahunbulan22ht", "tahunbulan23ht", "tahunbulan24ht" },
                values: new object[,]
                {
                    { "P05", 3, "Y", "202207", 1, "202208", 2, "202209", 2, "202210", 2, "202211", 3, "202212", 1, "202301", 1, "202302", 1, "202303", 1, "202304", 1, "202305", 2, "202306", 2, "202307", 2, "202308", 3, "202309", 1, "202310", 1, "202311", 1, "202312", 2, "202401", 2, "202402", 1, "202403", 1, "202404", 1, "202405", 1, "202406", 1, 0, 5, 35, 65, 95, 0, 0, 0, 0, 0, 7, 37, 67, 97, 0, 0, 0, 1, 31, 0, 0, 0, 0, 0 },
                    { "X-30", 1, "Y", "202207", 1, "202208", 1, "202209", 1, "202210", 1, "202211", 1, "202212", 2, "202301", 2, "202302", 2, "202303", 3, "202304", 1, "202305", 1, "202306", 1, "202307", 1, "202308", 1, "202309", 2, "202310", 2, "202311", 2, "202312", 3, "202401", 4, "202402", 1, "202403", 1, "202404", 1, "202405", 2, "202406", 2, 0, 0, 0, 0, 0, 0, 31, 61, 91, 0, 0, 0, 0, 0, 5, 35, 66, 96, 127, 0, 0, 0, 4, 34 },
                    { "X-30", 2, "N", "202207", 1, "202208", 2, "202209", 2, "202210", 2, "202211", 3, "202212", 4, "202301", 4, "202302", 5, "202303", 5, "202304", 5, "202305", 5, "202306", 5, "202307", 5, "202308", 5, "202309", 5, "202310", 5, "202311", 2, "202312", 5, "202401", 5, "202402", 5, "202403", 5, "202404", 5, "202405", 5, "202406", 5, 0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360, 390, 420, 450, 480, 510, 540, 570, 600, 630, 660, 690 }
                });

            migrationBuilder.InsertData(
                table: "Table_02",
                columns: new[] { "Id", "CIF", "DueDate", "FacilityStartDate", "FacilityType", "Installment", "MonthlyIncome", "Outstanding", "PercentageOfAnnualInterestRate", "Plafond", "Status", "Tenor", "UsageType" },
                values: new object[,]
                {
                    { 1, 999999, null, null, "Credit Card", 800000m, 23000000, 8000000, 30.2m, 10000000, "Yes", null, "Consumption" },
                    { 2, 999999, null, null, "Credit Card", 75000m, 23000000, 750000, 30.2m, 5000000, "Yes", null, "Consumption" },
                    { 3, 999999, 45918, 44457, "Personal Loan", 439058.91m, 23000000, 13000000, 17.8m, 15000000, "Yes", 48, "Consumption" },
                    { 4, 999999, 47765, 42265, "Mortgage", 7364307.72m, 23000000, 615000000, 7.8m, 780000000, "Yes", 180, "Consumption" }
                });

            migrationBuilder.InsertData(
                table: "Table_03",
                columns: new[] { "Id", "Age", "CIF", "Gender", "MonthlyIncome", "Occupation" },
                values: new object[] { 1, 45, 8888888, "Male", 23000000, "Employee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_01");

            migrationBuilder.DropTable(
                name: "Table_02");

            migrationBuilder.DropTable(
                name: "Table_03");
        }
    }
}
