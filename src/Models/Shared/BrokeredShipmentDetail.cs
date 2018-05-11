using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{    
    /// <summary>
    /// MS3 Interline Information
    /// </summary>
    public class BrokeredShipmentDetail
    {
        public string BrokerSCACCode { get; set; }
        public string BrokerTruckNumber { get; set; } //don't know if this is supported, but we'll leave it in
    }
}
