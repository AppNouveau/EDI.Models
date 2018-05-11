using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Models.Attributes;

namespace EDI.Models.LoadTenderResponse
{
    /// <summary>    
    /// </summary>
    public enum ReservationCodeType
    {        
        [EnumInfo("A", "Reservation Accepted")]
        Accepted,
        [EnumInfo("D", "Reservation Cancelled/Declined")]
        Declined        
    }
}
