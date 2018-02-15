using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.LoadTenderResponse
{
    public class ReservationStatus
    {
        public ReservationCodeType Status { get; set; }
        public DeclineReasonType DeclineReason { get; set; }
    }
}
