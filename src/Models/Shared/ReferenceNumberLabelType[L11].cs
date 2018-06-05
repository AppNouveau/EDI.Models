using EDI.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{
    public enum ReferenceNumberLabelType
    {
        Unknown,
        [EnumInfo("11", "Account Number", "See Penske.Transfreight documentation")]
        EntityAccountNumber,
        [EnumInfo("QY", "Service Performed Code", "See Penske.Transfreight documentation")]
        ServicePerformedCode,
        [EnumInfo("AG", "Partner Order Number")]
        PartnerOrderNumber,
        [EnumInfo("BN", "Booking Number")]
        BookingNumber,
        [EnumInfo("RU", "Route Number")]
        RouteNumber,
        HouseNumber,
        MAWB,
        ForwarderSCAC,
        CarrierReferenceNumber,
        ScheduleReferenceNumber,
        MutuallyDefined,
        BillOfLadingNumber,
        ShipperReferenceNumber,
        CustomerNumber,
        ConnectingCarrier,
    }
}
