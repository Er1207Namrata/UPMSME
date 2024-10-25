using CoreLayout.Models.Common;

namespace MSME.Models.Common
{
    public class SMSModel : BaseEntity
    {
        public string ServiceType { get; set; } = string.Empty;
        public string APIURL { get; set; } = string.Empty;
        public string APIResponse { get; set; } = string.Empty;
    }
}
