using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using EDI.Models.Attributes;
using EDI.Models;
using EDI.Models.MilestoneUpdate;
using EDI.Models.Shared;

namespace EDI.Models.MethodModels
{
    public class MilestoneUpdate : BaseMethodModel
    {        
        public string OrderNumber { get; set; }        
        public int StopNumber { get; set; }        
        public List<ReferenceNumber> ReferenceNumbers { get; set; }
        public List<Stop> Stops { get; set; }
        public DateTimeOffset MilestoneDateTime { get; set; }
        public Part MilestoneTotalParts { get; set; }        
        public MilestoneEventType MilestoneEvent { get; set; } = MilestoneEventType.ArrivedAtPickupLocation;
        public Location MilestoneLocation { get; set; }
        public MilestoneStatusReasonType MilestoneStatus { get; set; } = MilestoneStatusReasonType.Normal;
        public BrokeredShipmentDetail BrokeredShipment { get; set; } //Only supplied if brokered
        public string UnitID { get; set; }
    }       
}
