using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Models.Attributes;

namespace EDI.Models.LoadTenderResponse
{
    /// <summary>    
    /// </summary>
    public enum DeclineReasonType
    {
        [EnumInfo("0", "Not Applicable")]
        NotApplicable,
        [EnumInfo("A43", "Weather", "Weather or Natural Disaster Related")]
        Weather,        
        [EnumInfo("A30", "BreakDown", "Mechanical or Break Down Related")]
        BreakDown,
        [EnumInfo("A96", "Insufficient Pickup Time")]
        InsufficientPickupTime,
        [EnumInfo("A27", "Driver Related")]
        DriverRelated,
        [EnumInfo("D02", "Driver Not Available")]
        DriverNotAvailable,
        [EnumInfo("T07", "Insufficient Delivery Time")]
        InsufficientDeliveryTime,        
        [EnumInfo("A13", "Other")]
        Other
    }
}
