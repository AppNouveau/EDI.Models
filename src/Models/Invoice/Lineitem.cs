using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Invoice
{
    public class LineItem
    {
        public string Description { get; set; }
        public decimal Rate { get; set; }
        //public RateQualifierType RateQualifier { get; set; }
        public decimal Quantity { get; set; }
        public decimal LineCharge { get; set; }
        public ChargeDescriptionType ChargeDescriptionType { get; set; }
        public RateUnitOfMeasureType RateUnitOfMeasureType { get; set; }
    }
}
