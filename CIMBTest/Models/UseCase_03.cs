using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CIMBTest.Models
{
    public class UseCase_03
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CIF { get; set; }
        public int MonthlyIncome { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Occupation { get; set; }
    }
}
