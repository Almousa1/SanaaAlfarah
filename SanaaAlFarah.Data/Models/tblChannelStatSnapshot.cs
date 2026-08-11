namespace SanaaAlFarah.Data.Models
{
    public class tblChannelStatSnapshot : Common
    {
        public int ChannelId { get; set; }
        public tblChannel Channel { get; set; }
        public DateTime SnapshotDate { get; set; }
        public long Views {  get; set; }
        public long Subscribers { get; set; }
        public long Likes { get; set; }
        public int VideoCount { get; set; }
    }
}
