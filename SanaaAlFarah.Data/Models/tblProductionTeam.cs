namespace SanaaAlFarah.Data.Models
{
    public class tblProductionTeam : Common
    {
        public string TeamName { get; set; }
        public string TeamNameAr { get; set; }
        public string LogoUrl { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public string Address { get; set; }
        public string ConactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string TimeZone { get; set; } = "Asia/Riyadh";
        public string DefaultLanguage { get; set; } = "ar";
        public string IsApproved { get; set; }

    }
}
