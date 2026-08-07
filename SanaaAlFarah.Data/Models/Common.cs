namespace SanaaAlFarah.Data.Models;

public abstract class Common
{
    public int Id { get; set; }
    public Guid guid { get; set; } = Guid.NewGuid();
    public bool IsDeleted { get; set; } = false;
    public bool IsActive { get; set; } = true;
    public DateTime CreationDate { get; set; } = DateTime.Now;
}
