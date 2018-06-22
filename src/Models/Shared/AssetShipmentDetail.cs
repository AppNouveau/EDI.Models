using EDI.Models.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{        
    public class AssetShipmentDetail
    {        
        public string TruckNumber { get; set; }
        public TruckType TruckType { get; set; }
        public string TrailerNumber { get; set; }
    }
}
