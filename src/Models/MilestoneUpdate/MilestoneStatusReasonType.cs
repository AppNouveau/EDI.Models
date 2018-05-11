using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Models.Attributes;

namespace EDI.Models.MilestoneUpdate
{
    /// <summary>
    /// 
    /// </summary>
    public enum MilestoneStatusReasonType
    {
        [EnumInfo("NS", "Normal Status")]
        Normal,
        [EnumInfo("AO")]
        Weather,
        [EnumInfo("BE")]
        Traffic,
        [EnumInfo("BD")]
        Border,
        [EnumInfo("AI", "", "Mechanical or Break Down Related")]
        BreakDown,
        [EnumInfo("AF")]
        Accident,
        [EnumInfo("BE")]
        Construction,
        [EnumInfo("AM")]
        DelayedAtPickup,
        [EnumInfo("AL")]
        DelayedAtStopOff,
        [EnumInfo("AJ", "", "Dispatch Error or Operations Related")]
        DispatchError,
        [EnumInfo("A5", "", "Unable to Locate or Directions Related")]
        UnableToLocate
    }
}
