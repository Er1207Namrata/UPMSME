using CoreLayout.Models.Common;
using Microsoft.AspNetCore.Authentication;
using MSME.Models.Masters;
using MSME.Models.RAMP;
using System.ComponentModel.DataAnnotations;

namespace MSME.Models.Monitoring
{
    public class ZedMonitoringModel : BaseEntity
    {
        [Key]
        public int ZEDMonitoringId { get; set; }

        public string ForYear { get; set; }
        public string ForMonth { get; set; }
        public string IsZedWorkshopCalendarFinalisedYN { get; set; }
        public string ZedAwarenessSpreadYN { get; set; }

        public string OrganisedZedWorkshops { get; set; }
        public string TotZedCertAwarded { get; set; }
        public string SubmissionRepUCInvcYN { get; set; }

        public string ReportsBillsInvcValidatedYN { get; set; }

        public string FundDisbursementPerWorkshop { get; set; }


        public List<ZedMonitoringModel> ZedMonitoringList { get; set; } = new List<ZedMonitoringModel>();

        //public List<ZedMonitoringModel> ZEDMonitoringList { get; set; }

    }
}
