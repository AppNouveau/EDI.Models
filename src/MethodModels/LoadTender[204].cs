using EDI.Models.LoadTender;
using EDI.Models.Models.Shared;
using EDI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.MethodModels
{
    public class LoadTender : BaseMethodModel
    {
        public PartnerTransactionDetail PartnerTransactionDetail { get; set; }
        public MethodOfPaymentType MethodOfPayment { get; set; }
        public LoadTenderStatusType LoadTenderStatus { get; set; }
        public List<ReferenceNumber> ReferenceNumbers { get; set; } //Rename to identification codes/L11
        public DateTimeSpecial MustRespondByDateTime { get; set; } //G62*64[01]
        public List<Instruction> Instructions { get; set; } //NTE/Notes
        public List<Entity> BuisnessEntities { get; set; } //BillTO Responsible RemitTo
        public List<Stop> Stops { get; set; }
        public Part TotalParts { get; set; }        
        public RecommendedVehicleDetail RecommendedVehicle { get; set; }
        public decimal EstimatedTotalPay { get; set; }
    }

    public class RecommendedVehicleDetail
    {
        public VehicleType VehicleType { get; set; }
        public Dimension Dimension { get; set; }
    }
}
