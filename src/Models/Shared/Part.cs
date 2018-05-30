using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{
    /// <summary>
    /// OID or AT8 (for stops) or L3 (for total)       
    /// </summary>
    public class Part
    {
        public string ReferenceId { get; set; }
        public string PurchaseOrderNo { get; set; }
        public double Weight { get; set; }
        public double Quantity { get; set; }
        public WeightQualifierType WeightQualifier { get; set; }
        public WeightUnitType WeightUnitCode { get; set; }        
        public Dimension Dimension { get; set; }
        public Commodity Commodity { get; set; }
        public string BOL { get; set; }
        public string POD { get; set; }
    }
}
