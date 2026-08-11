namespace SanaaAlFarah.Data.Models;

public class tblContentCreator : Common
{
    public int SystemUserId { get; set; }
    public tblSystemUser SystemUser { get; set; }

    public string Bio { get; set; }
    public string BioAr { get; set; }
    public string ProfilePictureUrl { get; set; }
}
