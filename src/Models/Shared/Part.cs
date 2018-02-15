using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Shared
{
    /// <summary>
    /// OID or AT8 (for stops) or L3 (for total)              
    /// </summary>
    public class Part
    {
        public double Weight { get; set; }
        public double Quantity { get; set; }
        public WeightQualifierType WeightQualifier { get; set; }
        public WeightUnitType WeightUnitCode { get; set; }
        public string BOL { get; set; }
        public string POD { get; set; }
    }
}
