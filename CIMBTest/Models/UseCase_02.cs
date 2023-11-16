using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIMBTest.Models
{
    public class UseCase_02
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CIF { get; set; }
        public int MonthlyIncome { get; set; }
        public string? FacilityType { get; set; }
        public int Plafond { get; set; }
        public int Outstanding { get; set; }
        public int? DueDate { get; set; }
        public int? FacilityStartDate { get; set; }
        public decimal PercentageOfAnnualInterestRate { get; set; }
        public string? UsageType { get; set; }
        public string? Status { get; set; }
        public int? Tenor { get; set; }
        public decimal Installment { get; set; }

    }
}
