using EDI.Models.LoadTenderResponse;

namespace EDI.Models.MethodModels.Post
{
    public class LoadTenderResponse : BaseMethodModel
    {
        public string OrderNumber { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
    }
}
