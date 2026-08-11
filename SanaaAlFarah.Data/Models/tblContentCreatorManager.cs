namespace SanaaAlFarah.Data.Models;

public class tblContentCreatorManager : Common
{
    public int SystemUserId { get; set; }
    public tblSystemUser SystemUser { get; set; }

    public string Department { get; set; }
    public string DepartmentAr { get; set; }
}
