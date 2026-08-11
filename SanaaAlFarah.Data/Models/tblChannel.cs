namespace SanaaAlFarah.Data.Models
{
    public class tblChannel : Common
    {
        public int ContentCreatorId { get; set; }
        public tblContentCreator ContentCreator { get; set; }
        public string YouTubeChannelId { get; set; }
        public string ChannelName { get; set; }
        public string ChannelNameAr {  get; set; }
        public string ChannelUrl { get; set; }
        public string Description { get; set; }
        public string DescriptionAr { get; set; }
        public bool IsConnected { get; set; }
        public DateTime ConnectedAt { get; set; } = DateTime.Now;
        public DateTime? Disconnected {  get; set; }
        public DateTime LastRefreshedAt { get; set; }
    }
}
