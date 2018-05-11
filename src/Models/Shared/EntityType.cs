using EDI.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{
    public enum EntityType
    {        
        Unknown,
        Pickup,
        Delivery,
        BillTo,
        Broker,
        [EnumInfo("QD", "Responsible Party")]
        ResponsibleParty,
        [EnumInfo("RM", "Remit-To Party")]
        RemitToParty
    }
}
