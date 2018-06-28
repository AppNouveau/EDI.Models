using EDI.Models.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{        
    public class AssetShipmentDetail
    {        
        public string VehicleNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public string TrailerNumber { get; set; }
    }
}
