namespace SanaaAlFarah.Data.Models
{
    public class tblUser : Common
    {
       public string Email { get; set; }
       public string PasswordHash { get; set; }
       public string Name { get; set; }
       public string NameAr { get; set; }
       public string Phone { get; set; }
       public string Address { get; set; }

    }
}
