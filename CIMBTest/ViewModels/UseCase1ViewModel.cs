namespace CIMBTest.ViewModels
{
    public class UseCase1ViewModel
    {
        public int total { get; set; }
        public List<UseCase1DataViewModel>? listData {get;set;}
    }

   
    public class UseCase1DataViewModel
    {
        public string? jeniskredit { get; set; }
        public int? kreditno { get; set; }
        public string? Active { get; set; }
        public string? kolom { get; set; }
        public int? DPD { get; set; }
        public string? TahunBulan { get; set; }
        public int? Col { get; set; }


    }
}
