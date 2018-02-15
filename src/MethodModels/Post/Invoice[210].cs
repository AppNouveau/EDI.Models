using EDI.Library.Models.Invoice;
using EDI.Library.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.MethodModels.Post
{   
    public class Invoice : BaseMethodModel
    {        
        public string OrderNumber { get; set; }                
        public string InvoiceNumber { get; set; }
        public List<ReferenceNumber> ReferenceNumbers { get; set; }
        public List<Entity> BuisnessEntities { get; set; } //BillTO
        public DateTime InvoiceDate { get; set; }
        public DateTime FirstPickupDate { get; set; }
        public DateTime LastDeliveryDate { get; set; }
        public List<Stop> Stops { get; set; }
        public List<LineItem> LineItems { get; set; }
       
        public CurrencyType Currency { get; set; }
        public Part TotalParts { get; set; } //L0 and L3
    }
}
