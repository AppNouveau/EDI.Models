using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.MilestoneUpdate
{
    /// <summary>
    /// Not in use
    /// </summary>
    public class MilestoneStatusDetail
    {
        public MilestoneEventType ShipmentStatus { get; set; }
        public MilestoneStatusReasonType StatusReason { get; set; }
    }
}
