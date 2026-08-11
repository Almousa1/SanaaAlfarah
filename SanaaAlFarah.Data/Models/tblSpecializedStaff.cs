namespace SanaaAlFarah.Data.Models;

public class tblSpecializedStaff : Common
{
    public int SystemUserId { get; set; }
    public tblSystemUser SystemUser { get; set; }

    public string PortfolioUrl { get; set; }
    public int YearsOfExperience { get; set; }
}
