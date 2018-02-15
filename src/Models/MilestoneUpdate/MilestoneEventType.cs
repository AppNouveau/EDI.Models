using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Library.Attributes;

namespace EDI.Library.Models.MilestoneUpdate
{
    public enum MilestoneEventType
    {
        [EnumInfo("X3", "Arrived at Pick-Up Location")]
        ArrivedAtPickupLocation,
        [EnumInfo("AF", "Carrier Departed Pickup Location with Shipment")]
        LoadedAtPickupLocation,
        [EnumInfo("X1", "Arrived at Delivery Location")]
        ArrivedAtDeliveryLocation,
        [EnumInfo("CD", "Carrier Departed Delivery Location")]
        EmptiedAtDeliveryLocation,
        [EnumInfo("AG", "Carrier Departed Delivery Location")]
        ETAToFinalDelivery,
        [EnumInfo("X6", "EnRoute/Check-Call")]
        CheckCall
    }
}
