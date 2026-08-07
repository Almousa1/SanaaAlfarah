using SanaaAlFarah.Data.Models.Enums;

namespace SanaaAlFarah.Data.Models
{
    public class tblSystemUser : Common
    {
        public int UserId { get; set; }
        public tblUser User { get; set; }

        public int ProductionTeamId { get; set; }
        public tblProductionTeam ProductionTeam { get; set; }

        public UserRole Role { get; set; }

        public int? SpecializationId { get; set; }
        public tblSpecialization Specialization { get; set; }
    }
}
